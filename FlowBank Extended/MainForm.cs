using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FlowBank_Extended.API;
using FlowBank_Extended.API.Endpoints;
using FlowBank_Extended.API.Entities.Symbol;
using LiveCharts.Wpf;
using LiveCharts;
using LiveCharts.Configurations;
using FlowBank_Extended.Charting.ChartModels;
using LiveCharts.Defaults;
using System.Windows.Media;
using System.Net;
using Svg;
using FlowBank_Extended.Controls;

namespace FlowBank_Extended
{
    public partial class mainForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private List<string> AvailableCurrencies = new List<string>() { "CHF", "USD", "EUR" };

        public mainForm()
        {
            InitializeComponent();
            GoIntoFullscreen();
            LoadAccounts();
        }

        private void GoIntoFullscreen()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private async void LoadAccounts()
        {
            var accounts = await new AccountEndpoint().Get();

            foreach (var account in accounts.Data)
            {
                cmbAccount.Items.Add(account.AccountId);
            }

            if (accounts.Data.Any())
            {
                cmbAccount.SelectedIndex = 0;
            }
        }

        private async Task LoadSummary(Summary summary)
        {
            lblTotalAmount.Text = $"{summary.MoneyUsedForMargin} USD";

            DrawOverallSummary(summary);

            DrawAssetClassSummary(summary);

            await DrawPerformance(summary);

        }

        private async Task DrawPerformance(Summary summary)
        {
            int skipDays = 0;

            int.TryParse((string)cmbSkipDaysForDataPoints.SelectedItem ?? "", out skipDays);

            int oneMonthInDays = 30;
            int oneYearInDays = 365;
            var toDateTime = DateTime.Now.AddDays(-1);
            DateTime? fromDateTime = null;

            if (rdbPerformanceFiveDays.Checked)
            {
                fromDateTime = toDateTime.AddDays(-5);
            }
            if (rdbPerformanceOneMonth.Checked)
            {
                fromDateTime = toDateTime.AddDays(-oneMonthInDays);
            }
            if (rdbPerformanceSixMonths.Checked)
            {
                fromDateTime = toDateTime.AddDays(- 6 * oneMonthInDays);
            }
            if (rdbPerformanceYTD.Checked)
            {
                fromDateTime = new DateTime(toDateTime.Year, 1, 1);
            }
            if (rdbPerformanceOneYear.Checked)
            {
                fromDateTime = toDateTime.AddDays(-oneYearInDays);

            }
            if (rdbPerformanceFiveYear.Checked)
            {
                fromDateTime = toDateTime.AddDays(- 5% oneYearInDays);
            }
            if (rdbPerformanceMax.Checked)
            {
                fromDateTime = null;
            }

            var summariesOverTime = await new AccountSummaryEndpoint().GetFromToSummaries(summary.AccountId, summary.Currency, fromDateTime, toDateTime, skipDays);

            DrawHeatMapOverTime(summariesOverTime);
            var dayConfig = Mappers.Xy<DateTimeValueChartModel>()
                                   .X(dayModel => dayModel.DateTime.Ticks)
                                   .Y(dayModel => dayModel.Value);

            SeriesCollection series = new SeriesCollection(dayConfig);
            if (summariesOverTime.ResultCode == ApiResultCode.Ok)
            {
                LineSeries lineSeries = new LineSeries();

                lineSeries.Title = "Performance";
                lineSeries.Values = new ChartValues<DateTimeValueChartModel>();

                foreach (var summaryOfDay in summariesOverTime.Data)
                {
                    var chartValue = Math.Round(summaryOfDay.NetAssetValue, 2);
                    var chartModel = new DateTimeValueChartModel(summaryOfDay.SessionDate, chartValue);

                    if (chartValue > 0)
                        lineSeries.Values.Add(chartModel);

                }

                series.Add(lineSeries);

                var first = summariesOverTime.Data.Where(x => x.NetAssetValue > 0).OrderBy(x => x.SessionDate).FirstOrDefault();
                var last = summariesOverTime.Data.Where(x => x.NetAssetValue > 0).OrderByDescending(x => x.SessionDate).FirstOrDefault();

                if (first != null && last != null)
                {
                    LineSeries firstLastSeries = new LineSeries();
                    firstLastSeries.Title = "Trend";
                    firstLastSeries.Values = new ChartValues<DateTimeValueChartModel>();

                    var firstChartModel = new DateTimeValueChartModel(first.SessionDate, Math.Round(first.NetAssetValue, 2));
                    var lastChartModel = new DateTimeValueChartModel(last.SessionDate, Math.Round(last.NetAssetValue, 2));

                    firstLastSeries.Values.Add(firstChartModel);
                    firstLastSeries.Values.Add(lastChartModel);

                    firstLastSeries.Fill = System.Windows.Media.Brushes.Transparent;

                    if (firstChartModel.Value < lastChartModel.Value)
                    {
                        firstLastSeries.Stroke = System.Windows.Media.Brushes.Green;
                    }
                    else if (firstChartModel.Value > lastChartModel.Value)
                    {
                        firstLastSeries.Stroke = System.Windows.Media.Brushes.Red;
                    }
                    else
                    {
                        firstLastSeries.Stroke = System.Windows.Media.Brushes.Orange;
                    }
                    series.Add(firstLastSeries);
                }
            }

            Func<double, string> formatFunc = value => new DateTime((long)value).ToString("dd.MM.yyyy");

            cartesianChartPerformance.AxisX.Clear();
            cartesianChartPerformance.AxisX.Add(new Axis()
            {
                LabelFormatter = formatFunc
            });

            cartesianChartPerformance.Series = series;
        }

        private async void DrawHeatMapOverTime(ApiResult<Summary[]> summariesOverTime)
        {
            var appleResult = await new SymbolsEndpoint().GetById("AAPL.NASDAQ");


        }

        List<string> etfSymbolIds = new List<string>() { "SMICHA.SIX", "SPY.ARCA" };
        private void DrawAssetClassSummary(Summary summary)
        {
            // Adjust wrong data
            summary.Positions.ForEach(x => x.SymbolType = etfSymbolIds.Contains(x.SymbolId) ? SymbolType.FUND : x.SymbolType);

            var assetClassesGrouped = summary.Positions.GroupBy(x => x.SymbolType);

            var seriesCollection = new SeriesCollection();

            string labelPoint(ChartPoint chartPoint) => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            foreach (var item in assetClassesGrouped.OrderByDescending(item => GetFullGroupValue(item)))
            {
                seriesCollection.Add(new PieSeries()
                {
                    Title = item.First().SymbolType.ToString(),
                    Values = new ChartValues<double>(new List<double>() { GetFullGroupValue(item) }),
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Tag =  item.First().SymbolId
                });
            }

            pieChart1.DefaultLegend.Foreground = System.Windows.Media.Brushes.PaleGreen;
            pieChart1.Series = seriesCollection;
            pieChart1.LegendLocation = LegendLocation.Right;
        }

        private static double GetFullGroupValue(IGrouping<SymbolType, Position> item)
        {
            return Math.Round(item.Sum(x => double.Parse(x.Price) * double.Parse(x.Quantity)), 2);
        }

        private void DrawOverallSummary(Summary summary)
        {
            var seriesCollection = new SeriesCollection();

            string labelPoint(ChartPoint chartPoint) => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            foreach (var item in summary.Positions.OrderByDescending(item => GetFullPositionValue(item)))
            {
                seriesCollection.Add(new PieSeries()
                {
                    Title = item.SymbolId,
                    Values = new ChartValues<double>(new List<double>() { GetFullPositionValue(item) }),
                    DataLabels = true,
                    LabelPoint = labelPoint
                });
            }

            pieChartPositions.DefaultLegend.Foreground = System.Windows.Media.Brushes.PaleGreen;
            pieChartPositions.Series = seriesCollection;
            pieChartPositions.LegendLocation = LegendLocation.Right;
        }

        private static double GetFullPositionValue(Position item)
        {
            return Math.Round(double.Parse(item.Price) * double.Parse(item.Quantity), 2);
        }

        private async Task LoadAccountByCurrency(string currency)
        {
            var summary = await new AccountSummaryEndpoint().GetByAccountNr((string)cmbAccount.SelectedItem, currency);
            await LoadSummary(summary.Data);
        }

        private async void cmbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            var summary = await new AccountSummaryEndpoint().GetByAccountNr("QIG1063.001", "CHF");
            await LoadSummary(summary.Data);
        }


        private async void lol()
        {

            var listResult = await new SymbolsEndpoint().Get();
            var appleResult = await new SymbolsEndpoint().GetById("AAPL.NASDAQ");

            foreach (var item in listResult.Data)
            {
                // listSymbols.Items.Add(item.SymbolId);
                break;
            }

        }

        private void pnlDrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void PerformanceRadioButtonChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                if (cmbAccount.SelectedItem != null)
                {
                    var summary = await new AccountSummaryEndpoint().GetByAccountNr((string)cmbAccount.SelectedItem, "USD");
                    await DrawPerformance(summary.Data);
                }
            }
        }

        private async void cmbSkipDaysForDataPoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            var summary = await new AccountSummaryEndpoint().GetByAccountNr((string)cmbAccount.SelectedItem, "USD");
            await DrawPerformance(summary.Data);
        }

        private void btnMainView_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabMainWindow;
        }

        private void btnPositionDetails_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPositionWindow;
        }

        private void pieChartPositions_DataClick(object sender, ChartPoint chartPoint)
        {

            var xxxxx = chartPoint.SeriesView.Title;

            var summary = new AccountSummaryEndpoint().GetByAccountNr((string)cmbAccount.SelectedItem, "CHF").Result;

            stockListPanel.Controls.Clear();
            stockListPanel.Height = summary.Data.Positions.Count *100;

            int counter = 0;

            Panel headerPanel = new Panel();
            headerPanel.Width = stockListPanel.Width;
            headerPanel.Height = 60;
            headerPanel.Location = new Point(5, 0);
            headerPanel.BackColor = 0 % 2 == 0 ? System.Drawing.Color.Black : System.Drawing.Color.MidnightBlue;

            Label headerIconName = new Label();
            headerIconName.Text = "";
            headerIconName.ForeColor = System.Drawing.Color.PaleGreen;

            Label headerLabelName = new Label();
            headerLabelName.Text = "Firma";
            headerLabelName.ForeColor = System.Drawing.Color.PaleGreen;


            Label headerAveragePrice = new Label();
            headerAveragePrice.Text = "Avg. Price";
            headerAveragePrice.ForeColor = System.Drawing.Color.PaleGreen;

            Label headerCurrentPrice = new Label();
            headerCurrentPrice.Text = "Price";
            headerCurrentPrice.ForeColor = System.Drawing.Color.PaleGreen;

            TableLayoutPanel headerTableLayoutPanel = new TableLayoutPanel();
            headerTableLayoutPanel.ColumnCount = 4;
            headerTableLayoutPanel.Height = 100;
            headerTableLayoutPanel.Width = stockListPanel.Width;
            headerTableLayoutPanel.Padding = new Padding(5, 5, 0, 0);
            headerTableLayoutPanel.Dock = DockStyle.Fill;
            headerTableLayoutPanel.RowStyles.Add(new ColumnStyle(SizeType.Percent, 25));

            headerTableLayoutPanel.Controls.Add(headerIconName, 0, 0);
            headerTableLayoutPanel.Controls.Add(headerLabelName, 1, 0);
            headerTableLayoutPanel.Controls.Add(headerAveragePrice, 2, 0);
            headerTableLayoutPanel.Controls.Add(headerCurrentPrice, 3, 0);
            headerPanel.Controls.Add(headerTableLayoutPanel);
            stockListPanel.Controls.Add(headerPanel);

            foreach (var positionInformation in summary.Data.Positions)
            {
                counter++;
                AddPanelRowOld(counter, positionInformation);
                AddPanelRowNew(counter, positionInformation);
                counter++;
            }

            // var positionSymbol = chartPoint.SeriesView.Title;
            // tabControl.SelectedTab = tabPositionWindow;
        }

        private void AddPanelRowNew(int counter, Position positionInformation)
        {
            var symbolInformation = new SymbolsEndpoint().GetById(positionInformation.SymbolId).Result;

            PositionOverviewTableRow positionOverviewTableRow = new PositionOverviewTableRow();
            positionOverviewTableRow.SetInformation(positionInformation, symbolInformation.Data);
            stockListPanel.Controls.Add(positionOverviewTableRow);
        }

        private void AddPanelRowOld(int counter, Position positionInformation)
        {
            var symbolInformation = new SymbolsEndpoint().GetById(positionInformation.SymbolId).Result;

            Panel panel = new Panel();
            panel.Width = stockListPanel.Width;
            panel.Height = 100;
            panel.Location = new Point(5, 100 * counter);
            panel.BackColor = counter % 2 == 0 ? System.Drawing.Color.DarkGreen : System.Drawing.Color.MidnightBlue;

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.Height = 100;
            tableLayoutPanel.Width = panel.Width;
            tableLayoutPanel.Padding = new Padding(5, 5, 0, 0);
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25));
            tableLayoutPanel.Dock = DockStyle.Fill;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Height = 90;
            pictureBox.Width = 90;
            pictureBox.Padding = new Padding(0);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            if (!string.IsNullOrEmpty(symbolInformation.Data.Icon))
            {
                if (symbolInformation.Data.Icon.Contains(".png"))
                {
                    pictureBox.Image = GetBitmapFromPngUrl(symbolInformation.Data.Icon);
                }
                else
                {
                    pictureBox.Image = GetBitmapFromSvgUrl(symbolInformation.Data.Icon);
                }
            }

            Label labelName = new Label();
            labelName.Text = symbolInformation.Data.Name;
            labelName.ForeColor = System.Drawing.Color.PaleGreen;

            Label averagePrice = new Label();
            averagePrice.Text = $"{positionInformation.AveragePrice} {positionInformation.Currency}";
            averagePrice.ForeColor = System.Drawing.Color.PaleGreen;

            Label currentPrice = new Label();
            currentPrice.Text = $"{positionInformation.Price} {positionInformation.Currency}";
            currentPrice.ForeColor = (double.Parse(positionInformation.AveragePrice) < double.Parse(positionInformation.Price)) ? System.Drawing.Color.OrangeRed : System.Drawing.Color.LightGreen;

            tableLayoutPanel.Controls.Add(pictureBox, 0, 0);
            tableLayoutPanel.Controls.Add(labelName, 1, 0);
            tableLayoutPanel.Controls.Add(averagePrice, 2, 0);
            tableLayoutPanel.Controls.Add(currentPrice, 3, 0);
            panel.Controls.Add(tableLayoutPanel);
            stockListPanel.Controls.Add(panel);
        }
    }

}
