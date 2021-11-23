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

        public PositionOverviewTableRow()
        {
            InitializeComponent();
        }

        internal void SetInformation(Position positionInformation, SymbolResult symbolInformation)
        {

            this.lblStockName.Text = symbolInformation.Name;
            this.lblStockAverageBuy.Text = $"{positionInformation.AveragePrice} {positionInformation.Currency}";
            this.lblStockCurrentPrice.Text = $"{positionInformation.Price} {positionInformation.Currency}";

            double plPerShare = double.Parse(positionInformation.Price) - double.Parse(positionInformation.AveragePrice);
            this.lblStockGainPerShare.Text = $"{plPerShare} {positionInformation.Currency}";

            this.lblStockGainPerShare.ForeColor = plPerShare <= 0 ? System.Drawing.Color.OrangeRed : System.Drawing.Color.LightGreen;

            TrySetIcon(symbolInformation);
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
}
