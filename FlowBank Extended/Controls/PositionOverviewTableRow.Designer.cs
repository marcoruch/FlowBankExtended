namespace FlowBank_Extended.Controls
{
    partial class PositionOverviewTableRow
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMainRowLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStockName = new System.Windows.Forms.Label();
            this.lblStockCurrentPrice = new System.Windows.Forms.Label();
            this.lblStockAverageBuy = new System.Windows.Forms.Label();
            this.lblStockGainPerShare = new System.Windows.Forms.Label();
            this.lblHoldings = new System.Windows.Forms.Label();
            this.tlpMainRowLayoutPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMainRowLayoutPanel
            // 
            this.tlpMainRowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tlpMainRowLayoutPanel.ColumnCount = 6;
            this.tlpMainRowLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpMainRowLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMainRowLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMainRowLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMainRowLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMainRowLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMainRowLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMainRowLayoutPanel.Controls.Add(this.panel4, 4, 0);
            this.tlpMainRowLayoutPanel.Controls.Add(this.panel3, 3, 0);
            this.tlpMainRowLayoutPanel.Controls.Add(this.panel2, 2, 0);
            this.tlpMainRowLayoutPanel.Controls.Add(this.pbIcon, 0, 0);
            this.tlpMainRowLayoutPanel.Controls.Add(this.panel1, 1, 0);
            this.tlpMainRowLayoutPanel.Controls.Add(this.lblHoldings, 5, 0);
            this.tlpMainRowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainRowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tlpMainRowLayoutPanel.Name = "tlpMainRowLayoutPanel";
            this.tlpMainRowLayoutPanel.RowCount = 1;
            this.tlpMainRowLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainRowLayoutPanel.Size = new System.Drawing.Size(1096, 100);
            this.tlpMainRowLayoutPanel.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.lblStockGainPerShare);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(700, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(193, 94);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lblStockAverageBuy);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(501, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 94);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblStockCurrentPrice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(302, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 94);
            this.panel2.TabIndex = 2;
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbIcon.Location = new System.Drawing.Point(3, 3);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(94, 94);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblStockName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(103, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 94);
            this.panel1.TabIndex = 1;
            // 
            // lblStockName
            // 
            this.lblStockName.BackColor = System.Drawing.Color.Transparent;
            this.lblStockName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStockName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblStockName.Location = new System.Drawing.Point(0, 0);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(193, 94);
            this.lblStockName.TabIndex = 0;
            this.lblStockName.Text = "SampleText";
            this.lblStockName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStockCurrentPrice
            // 
            this.lblStockCurrentPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblStockCurrentPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStockCurrentPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockCurrentPrice.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblStockCurrentPrice.Location = new System.Drawing.Point(0, 0);
            this.lblStockCurrentPrice.Name = "lblStockCurrentPrice";
            this.lblStockCurrentPrice.Size = new System.Drawing.Size(193, 94);
            this.lblStockCurrentPrice.TabIndex = 1;
            this.lblStockCurrentPrice.Text = "SampleText";
            this.lblStockCurrentPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStockAverageBuy
            // 
            this.lblStockAverageBuy.BackColor = System.Drawing.Color.Transparent;
            this.lblStockAverageBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStockAverageBuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockAverageBuy.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblStockAverageBuy.Location = new System.Drawing.Point(0, 0);
            this.lblStockAverageBuy.Name = "lblStockAverageBuy";
            this.lblStockAverageBuy.Size = new System.Drawing.Size(193, 94);
            this.lblStockAverageBuy.TabIndex = 2;
            this.lblStockAverageBuy.Text = "SampleText";
            this.lblStockAverageBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStockGainPerShare
            // 
            this.lblStockGainPerShare.BackColor = System.Drawing.Color.Transparent;
            this.lblStockGainPerShare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStockGainPerShare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockGainPerShare.Location = new System.Drawing.Point(0, 0);
            this.lblStockGainPerShare.Name = "lblStockGainPerShare";
            this.lblStockGainPerShare.Size = new System.Drawing.Size(193, 94);
            this.lblStockGainPerShare.TabIndex = 2;
            this.lblStockGainPerShare.Text = "SampleText";
            this.lblStockGainPerShare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHoldings
            // 
            this.lblHoldings.BackColor = System.Drawing.Color.Transparent;
            this.lblHoldings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHoldings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHoldings.Location = new System.Drawing.Point(899, 0);
            this.lblHoldings.Name = "lblHoldings";
            this.lblHoldings.Size = new System.Drawing.Size(194, 100);
            this.lblHoldings.TabIndex = 5;
            this.lblHoldings.Text = "SampleText";
            this.lblHoldings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PositionOverviewTableRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tlpMainRowLayoutPanel);
            this.Name = "PositionOverviewTableRow";
            this.Size = new System.Drawing.Size(1096, 100);
            this.tlpMainRowLayoutPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainRowLayoutPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStockName;
        private System.Windows.Forms.Label lblStockGainPerShare;
        private System.Windows.Forms.Label lblStockAverageBuy;
        private System.Windows.Forms.Label lblStockCurrentPrice;
        private System.Windows.Forms.Label lblHoldings;
    }
}
