using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlowBank_Extended.API;
using FlowBank_Extended.API.Entities.Symbol;
using FlowBank_Extended.Helpers;
using FlowBank_Extended.API.Endpoints;

namespace FlowBank_Extended.Controls
{
    public partial class PositionOverviewTableRow : UserControl
    {
        public Label LabelStockAverageBuy
        {
            get { return this.lblStockAverageBuy; }
        }
        public Label LabelStockCurrentPrice
        {
            get { return this.lblStockCurrentPrice; }
        }
        public Label LabelStockGainPerShare
        {
            get { return this.lblStockGainPerShare; }
        }
        public Label LabelStockName
        {
            get { return this.lblStockName; }
        }

        public TableLayoutPanel MainRowLayoutPanel
        {
            get { return this.tlpMainRowLayoutPanel;  }
        }

        private bool IsHeaderRow { get; }

        public PositionOverviewTableRow(bool isHeaderRow = false)
        {
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

            double plPerShare = double.Parse(positionInformation.Price) - double.Parse(positionInformation.AveragePrice);
            lblStockGainPerShare.Text = $"{plPerShare} {positionInformation.Currency}";

            lblStockGainPerShare.ForeColor = plPerShare <= 0 ? Color.OrangeRed : Color.LightGreen;

            TrySetIcon(symbolInformation);
        }


        private void SetHeaderRowInformation()
        {
            this.lblStockName.Text = "Name";
            this.lblStockAverageBuy.Text = "Average Buy";
            this.lblStockCurrentPrice.Text = "Current Price";
            this.lblStockGainPerShare.Text = "Gains per Share";
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
        }
    }

    public class PositionOverViewTableToPanelLoader
    {
        // To maybe load later
        public PositionOverViewTableToPanelLoader(Panel panel)
        {
            panel.Controls.Clear();
            AddHeaderRow(panel);
        }

        public PositionOverViewTableToPanelLoader(Panel panel, List<Position> positions)
        {
            LoadControl(panel, positions);
        }


        public void LoadControl(Panel panel, List<Position> positions)
        {
            panel.Controls.Clear();

            AddHeaderRow(panel);

            int counter = 1;
            foreach (var position in positions)
            {
                AddPanelRowNew(panel, position, counter++);
            }

        }


        private void AddHeaderRow(Panel panel)
        {
            PositionOverviewTableRow positionOverviewTableRow = new PositionOverviewTableRow(true);

            SetWidthToPanelWidth(panel, positionOverviewTableRow);
            panel.Controls.Add(positionOverviewTableRow);
        }

        private static void SetWidthToPanelWidth(Panel panel, PositionOverviewTableRow positionOverviewTableRow)
        {
            positionOverviewTableRow.Width = panel.Width;
            positionOverviewTableRow.MainRowLayoutPanel.ColumnStyles[0].SizeType = SizeType.Absolute;
            positionOverviewTableRow.MainRowLayoutPanel.ColumnStyles[0].Width = 90;
        }

        public void AddPanelRowNew(Panel panel, Position positionInformation, int counter)
        {
            var symbolInformation = new SymbolsEndpoint().GetById(positionInformation.SymbolId).Result;

            PositionOverviewTableRow positionOverviewTableRow = new PositionOverviewTableRow();
            positionOverviewTableRow.Location = new Point(positionOverviewTableRow.Location.X, counter * positionOverviewTableRow.Height);

            SetWidthToPanelWidth(panel, positionOverviewTableRow);


            positionOverviewTableRow.SetInformation(positionInformation, symbolInformation.Data);
            panel.Controls.Add(positionOverviewTableRow);
        }
    }

}
