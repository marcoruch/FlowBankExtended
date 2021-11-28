using FlowBank_Extended.API.Endpoints;
using FlowBank_Extended.API.Entities.Symbol;
using FlowBank_Extended.Controls;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FlowBank_Extended.Helpers
{
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
            if (panel.InvokeRequired)
            {
                panel.Invoke((MethodInvoker)delegate ()
                {
                    DoLoadControl(panel, positions);
                });
            }
            else
            {
                DoLoadControl(panel, positions);
            }
        }

        private void DoLoadControl(Panel panel, List<Position> positions)
        {
            panel.Controls.Clear();

            panel.Dock = DockStyle.None;

            AddHeaderRow(panel);

            int counter = 1;
            foreach (var position in positions)
            {
                AddPanelRowNew(panel, position, counter++);
            }

            panel.Width = panel.Parent.Width;
            panel.Height= panel.Parent.Height;

            panel.AutoScroll = true;
            panel.HorizontalScroll.Enabled = false;
            panel.HorizontalScroll.Visible = false;

            panel.VerticalScroll.Visible = false;
        }

        private void AddHeaderRow(Panel panel)
        {
            PositionOverviewTableRow positionOverviewTableRow = new PositionOverviewTableRow(true);

            positionOverviewTableRow.RecalculateRowWidthToPanel(panel);

            panel.Controls.Add(positionOverviewTableRow);
        }

        public void AddPanelRowNew(Panel panel, Position positionInformation, int counter)
        {
            var symbolInformation = new SymbolsEndpoint().GetById(positionInformation.SymbolId).Result;

            PositionOverviewTableRow positionOverviewTableRow = new PositionOverviewTableRow();
            positionOverviewTableRow.Location = new Point(positionOverviewTableRow.Location.X, counter * positionOverviewTableRow.Height);

            positionOverviewTableRow.RecalculateRowWidthToPanel(panel);


            positionOverviewTableRow.SetInformation(positionInformation, symbolInformation.Data);
            positionOverviewTableRow.SetColor(counter);
            panel.Controls.Add(positionOverviewTableRow);
            positionOverviewTableRow.Visible = true;
            positionOverviewTableRow.Update();
        }
    }
}
