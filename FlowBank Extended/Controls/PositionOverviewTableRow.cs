using FlowBank_Extended.API.Entities.Symbol;
using FlowBank_Extended.Helpers;

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FlowBank_Extended.Controls
{
    public partial class PositionOverviewTableRow : UserControl
    {
        private bool IsHeaderRow { get; }

        public PositionOverviewTableRow(bool isHeaderRow = false)
        {
            this.Visible = false;
            InitializeComponent();
            this.IsHeaderRow = isHeaderRow;

            if (this.IsHeaderRow)
            {
                SetHeaderRowInformation();
            }
        }

        public void SetInformation(Position positionInformation, SymbolResult symbolInformation)
        {
            lblStockName.Text = symbolInformation.Name;
            lblStockAverageBuy.Text = $"{positionInformation.AveragePrice} {positionInformation.Currency}";
            lblStockCurrentPrice.Text = $"{positionInformation.Price} {positionInformation.Currency}";

            double plPerShare = Math.Round(double.Parse(positionInformation.Price) - double.Parse(positionInformation.AveragePrice), 2);
            lblStockGainPerShare.Text = $"{plPerShare} {positionInformation.Currency}";

            lblStockGainPerShare.ForeColor = plPerShare <= 0 ? Color.OrangeRed : Color.LightGreen;

            lblHoldings.Text = $"{Math.Round(double.Parse(positionInformation.ConvertedValue), 2)} {positionInformation.Currency}";
            lblHoldings.ForeColor = plPerShare <= 0 ? Color.OrangeRed : Color.LightGreen;

            TrySetIcon(symbolInformation);
        }


        private void SetHeaderRowInformation()
        {
            lblStockName.Text = "Name";
            lblStockAverageBuy.Text = "Average Buy";
            lblStockCurrentPrice.Text = "Current Price";
            lblStockGainPerShare.Text = "Gains Per Share";
            lblHoldings.Text = "Holdings";
            MakeHeaderRowStyle(lblStockName);
            MakeHeaderRowStyle(lblStockAverageBuy);
            MakeHeaderRowStyle(lblStockCurrentPrice);
            MakeHeaderRowStyle(lblStockGainPerShare);
            MakeHeaderRowStyle(lblHoldings);
            this.Visible = true;
            this.Update();
        }

        private void MakeHeaderRowStyle(Label label)
        {
            label.Font = new Font(lblStockName.Font.FontFamily.Name, 16, FontStyle.Bold);
            label.ForeColor = Color.MediumAquamarine;
        }

        private void TrySetIcon(SymbolResult symbolInformation)
        {
            if (!string.IsNullOrEmpty(symbolInformation.Icon))
            {
                if (symbolInformation.Icon.Contains(".png"))
                {
                    pbIcon.Image = IconHelper.GetBitmapFromPngUrl(symbolInformation.Icon);
                }
                else
                {
                    pbIcon.Image = IconHelper.GetBitmapFromSvgUrl(symbolInformation.Icon);
                }
            }

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(pbIcon.DisplayRectangle);
            pbIcon.Region = new Region(gp);
        }

        internal void SetColor(int counter)
        {
            if (counter % 2 == 0)
            {
                this.BackColor = Color.FromArgb(175, Color.LightCyan);
            }
            else
            {
                this.BackColor = Color.FromArgb(175, Color.LightGoldenrodYellow);
            }
        }

        public void RecalculateRowWidthToPanel(Panel panel)
        {
            this.Width = panel.Width - 35;
            tlpMainRowLayoutPanel.ColumnStyles[0].SizeType = SizeType.Absolute;
            tlpMainRowLayoutPanel.ColumnStyles[0].Width = 90;
        }
    }
}
