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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblStockName = new System.Windows.Forms.Label();
            this.lblStockCurrentPrice = new System.Windows.Forms.Label();
            this.lblStockAverageBuy = new System.Windows.Forms.Label();
            this.lblStockGainPerShare = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.47475F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.47475F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.47475F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.47475F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbIcon, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1098, 106);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblStockName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(113, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStockCurrentPrice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(359, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 100);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblStockAverageBuy);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(605, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 100);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblStockGainPerShare);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(851, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 100);
            this.panel4.TabIndex = 4;
            // 
            // lblStockName
            // 
            this.lblStockName.AutoSize = true;
            this.lblStockName.Location = new System.Drawing.Point(79, 40);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(51, 20);
            this.lblStockName.TabIndex = 0;
            this.lblStockName.Text = "label1";
            // 
            // lblStockCurrentPrice
            // 
            this.lblStockCurrentPrice.AutoSize = true;
            this.lblStockCurrentPrice.Location = new System.Drawing.Point(103, 40);
            this.lblStockCurrentPrice.Name = "lblStockCurrentPrice";
            this.lblStockCurrentPrice.Size = new System.Drawing.Size(51, 20);
            this.lblStockCurrentPrice.TabIndex = 0;
            this.lblStockCurrentPrice.Text = "label2";
            // 
            // lblStockAverageBuy
            // 
            this.lblStockAverageBuy.AutoSize = true;
            this.lblStockAverageBuy.Location = new System.Drawing.Point(95, 40);
            this.lblStockAverageBuy.Name = "lblStockAverageBuy";
            this.lblStockAverageBuy.Size = new System.Drawing.Size(51, 20);
            this.lblStockAverageBuy.TabIndex = 1;
            this.lblStockAverageBuy.Text = "label3";
            // 
            // lblStockGainPerShare
            // 
            this.lblStockGainPerShare.AutoSize = true;
            this.lblStockGainPerShare.Location = new System.Drawing.Point(97, 40);
            this.lblStockGainPerShare.Name = "lblStockGainPerShare";
            this.lblStockGainPerShare.Size = new System.Drawing.Size(51, 20);
            this.lblStockGainPerShare.TabIndex = 1;
            this.lblStockGainPerShare.Text = "label4";
            // 
            // pbIcon
            // 
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbIcon.Location = new System.Drawing.Point(3, 3);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(104, 100);
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // PositionOverviewTableRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PositionOverviewTableRow";
            this.Size = new System.Drawing.Size(1098, 106);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblStockGainPerShare;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblStockAverageBuy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStockCurrentPrice;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStockName;
    }
}
