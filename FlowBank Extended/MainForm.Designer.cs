namespace FlowBank_Extended
{
    partial class mainForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpOverallLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMenuBar = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.tlpMenuLeft = new System.Windows.Forms.TableLayoutPanel();
            this.btnPositionDetails = new System.Windows.Forms.Button();
            this.btnMainView = new System.Windows.Forms.Button();
            this.pnlDrag = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlMainView = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMainWindow = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pieChartPositions = new LiveCharts.WinForms.PieChart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabPositionWindow = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.pieChart2 = new LiveCharts.WinForms.PieChart();
            this.tlpStockPanelHolder = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cartesianChartPerformance = new LiveCharts.WinForms.CartesianChart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPerformanceChartDaySkipperHolder = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSkipDaysForDataPoints = new System.Windows.Forms.ComboBox();
            this.rdbPerformanceMax = new System.Windows.Forms.RadioButton();
            this.rdbPerformanceFiveDays = new System.Windows.Forms.RadioButton();
            this.rdbPerformanceOneMonth = new System.Windows.Forms.RadioButton();
            this.rdbPerformanceFiveYear = new System.Windows.Forms.RadioButton();
            this.rdbPerformanceSixMonths = new System.Windows.Forms.RadioButton();
            this.rdbPerformanceOneYear = new System.Windows.Forms.RadioButton();
            this.rdbPerformanceYTD = new System.Windows.Forms.RadioButton();
            this.stockListPanel = new System.Windows.Forms.Panel();
            this.tlpOverallLayout.SuspendLayout();
            this.tlpMenuBar.SuspendLayout();
            this.tlpMenuLeft.SuspendLayout();
            this.pnlDrag.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlMainView.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMainWindow.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlpStockPanelHolder.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tlpPerformanceChartDaySkipperHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpOverallLayout
            // 
            this.tlpOverallLayout.AutoSize = true;
            this.tlpOverallLayout.ColumnCount = 2;
            this.tlpOverallLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.75F));
            this.tlpOverallLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.25F));
            this.tlpOverallLayout.Controls.Add(this.tlpMenuBar, 0, 1);
            this.tlpOverallLayout.Controls.Add(this.pnlDrag, 1, 0);
            this.tlpOverallLayout.Controls.Add(this.pnlLogo, 0, 0);
            this.tlpOverallLayout.Controls.Add(this.pnlMainView, 1, 1);
            this.tlpOverallLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOverallLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpOverallLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tlpOverallLayout.Name = "tlpOverallLayout";
            this.tlpOverallLayout.RowCount = 2;
            this.tlpOverallLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tlpOverallLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOverallLayout.Size = new System.Drawing.Size(7680, 2186);
            this.tlpOverallLayout.TabIndex = 1;
            // 
            // tlpMenuBar
            // 
            this.tlpMenuBar.BackColor = System.Drawing.Color.SlateGray;
            this.tlpMenuBar.ColumnCount = 1;
            this.tlpMenuBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMenuBar.Controls.Add(this.btnExit, 0, 3);
            this.tlpMenuBar.Controls.Add(this.tlpMenuLeft, 0, 0);
            this.tlpMenuBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenuBar.Location = new System.Drawing.Point(0, 135);
            this.tlpMenuBar.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMenuBar.Name = "tlpMenuBar";
            this.tlpMenuBar.RowCount = 4;
            this.tlpMenuBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.95562F));
            this.tlpMenuBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.044383F));
            this.tlpMenuBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tlpMenuBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tlpMenuBar.Size = new System.Drawing.Size(1056, 2051);
            this.tlpMenuBar.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(102)))), ((int)(((byte)(94)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(0, 1958);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(1056, 93);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Beenden";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tlpMenuLeft
            // 
            this.tlpMenuLeft.ColumnCount = 1;
            this.tlpMenuLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenuLeft.Controls.Add(this.btnPositionDetails, 0, 1);
            this.tlpMenuLeft.Controls.Add(this.btnMainView, 0, 0);
            this.tlpMenuLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenuLeft.Location = new System.Drawing.Point(3, 3);
            this.tlpMenuLeft.Name = "tlpMenuLeft";
            this.tlpMenuLeft.RowCount = 4;
            this.tlpMenuLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMenuLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMenuLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMenuLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMenuLeft.Size = new System.Drawing.Size(1050, 1634);
            this.tlpMenuLeft.TabIndex = 3;
            // 
            // btnPositionDetails
            // 
            this.btnPositionDetails.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPositionDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPositionDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPositionDetails.Location = new System.Drawing.Point(3, 411);
            this.btnPositionDetails.Name = "btnPositionDetails";
            this.btnPositionDetails.Size = new System.Drawing.Size(1044, 402);
            this.btnPositionDetails.TabIndex = 1;
            this.btnPositionDetails.Text = "Hauptmenü";
            this.btnPositionDetails.UseVisualStyleBackColor = false;
            this.btnPositionDetails.Click += new System.EventHandler(this.btnPositionDetails_Click);
            // 
            // btnMainView
            // 
            this.btnMainView.BackColor = System.Drawing.Color.Khaki;
            this.btnMainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMainView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainView.Location = new System.Drawing.Point(3, 3);
            this.btnMainView.Name = "btnMainView";
            this.btnMainView.Size = new System.Drawing.Size(1044, 402);
            this.btnMainView.TabIndex = 0;
            this.btnMainView.Text = "Hauptmenü";
            this.btnMainView.UseVisualStyleBackColor = false;
            this.btnMainView.Click += new System.EventHandler(this.btnMainView_Click);
            // 
            // pnlDrag
            // 
            this.pnlDrag.BackColor = System.Drawing.Color.SlateGray;
            this.pnlDrag.Controls.Add(this.tableLayoutPanel2);
            this.pnlDrag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDrag.Location = new System.Drawing.Point(1059, 3);
            this.pnlDrag.Name = "pnlDrag";
            this.pnlDrag.Size = new System.Drawing.Size(6618, 129);
            this.pnlDrag.TabIndex = 5;
            this.pnlDrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDrag_MouseMove);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.17708F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.45114F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.39144F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.1252F));
            this.tableLayoutPanel2.Controls.Add(this.lblAccount, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalAmount, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTotal, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbAccount, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1262, 57);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // lblAccount
            // 
            this.lblAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.Color.Lime;
            this.lblAccount.Location = new System.Drawing.Point(3, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(235, 57);
            this.lblAccount.TabIndex = 3;
            this.lblAccount.Text = "Account:";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Crimson;
            this.lblTotalAmount.Location = new System.Drawing.Point(745, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 37);
            this.lblTotalAmount.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTotal.ForeColor = System.Drawing.Color.Lime;
            this.lblTotal.Location = new System.Drawing.Point(577, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(162, 57);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbAccount
            // 
            this.cmbAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Location = new System.Drawing.Point(244, 3);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(327, 45);
            this.cmbAccount.TabIndex = 2;
            this.cmbAccount.SelectedIndexChanged += new System.EventHandler(this.cmbAccount_SelectedIndexChanged);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlLogo.BackgroundImage = global::FlowBank_Extended.Properties.Resources.flowbank_logo_green;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogo.Location = new System.Drawing.Point(3, 3);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(1050, 129);
            this.pnlLogo.TabIndex = 6;
            // 
            // pnlMainView
            // 
            this.pnlMainView.AutoSize = true;
            this.pnlMainView.Controls.Add(this.tabControl);
            this.pnlMainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainView.Location = new System.Drawing.Point(1059, 138);
            this.pnlMainView.Name = "pnlMainView";
            this.pnlMainView.Size = new System.Drawing.Size(6618, 2045);
            this.pnlMainView.TabIndex = 7;
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabMainWindow);
            this.tabControl.Controls.Add(this.tabPositionWindow);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(6618, 2045);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 24;
            // 
            // tabMainWindow
            // 
            this.tabMainWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tabMainWindow.Controls.Add(this.tableLayoutPanel1);
            this.tabMainWindow.Location = new System.Drawing.Point(4, 5);
            this.tabMainWindow.Name = "tabMainWindow";
            this.tabMainWindow.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainWindow.Size = new System.Drawing.Size(6610, 2036);
            this.tabMainWindow.TabIndex = 0;
            this.tabMainWindow.Text = "tabPage1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pieChartPositions, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2030F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(6604, 2030);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // pieChartPositions
            // 
            this.pieChartPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartPositions.Location = new System.Drawing.Point(3, 3);
            this.pieChartPositions.Name = "pieChartPositions";
            this.pieChartPositions.Size = new System.Drawing.Size(3296, 2024);
            this.pieChartPositions.TabIndex = 10;
            this.pieChartPositions.Text = "pieChartPositions";
            this.pieChartPositions.DataClick += new LiveCharts.Events.DataClickHandler(this.pieChartPositions_DataClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3305, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3296, 2024);
            this.panel2.TabIndex = 11;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(3296, 2024);
            this.tableLayoutPanel4.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3290, 601);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tlpStockPanelHolder);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 610);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3290, 1411);
            this.panel4.TabIndex = 1;
            // 
            // tabPositionWindow
            // 
            this.tabPositionWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tabPositionWindow.Location = new System.Drawing.Point(4, 5);
            this.tabPositionWindow.Name = "tabPositionWindow";
            this.tabPositionWindow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPositionWindow.Size = new System.Drawing.Size(6610, 2036);
            this.tabPositionWindow.TabIndex = 1;
            this.tabPositionWindow.Text = "tabPage2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.pieChart2);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(6610, 2036);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pieChart1);
            this.panel1.Location = new System.Drawing.Point(1853, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1784, 1555);
            this.panel1.TabIndex = 12;
            // 
            // pieChart1
            // 
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart1.Location = new System.Drawing.Point(0, 0);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(1784, 1555);
            this.pieChart1.TabIndex = 14;
            this.pieChart1.Text = "pieChart1";
            // 
            // pieChart2
            // 
            this.pieChart2.Location = new System.Drawing.Point(253, 129);
            this.pieChart2.Name = "pieChart2";
            this.pieChart2.Size = new System.Drawing.Size(854, 564);
            this.pieChart2.TabIndex = 11;
            this.pieChart2.Text = "pieChart2";
            // 
            // tlpStockPanelHolder
            // 
            this.tlpStockPanelHolder.ColumnCount = 1;
            this.tlpStockPanelHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStockPanelHolder.Controls.Add(this.stockListPanel, 0, 0);
            this.tlpStockPanelHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStockPanelHolder.Location = new System.Drawing.Point(0, 0);
            this.tlpStockPanelHolder.Name = "tlpStockPanelHolder";
            this.tlpStockPanelHolder.RowCount = 1;
            this.tlpStockPanelHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1334F));
            this.tlpStockPanelHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStockPanelHolder.Size = new System.Drawing.Size(3290, 1411);
            this.tlpStockPanelHolder.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.30616F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.69384F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(3290, 601);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cartesianChartPerformance);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(4, 102);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3282, 495);
            this.panel5.TabIndex = 50;
            // 
            // cartesianChartPerformance
            // 
            this.cartesianChartPerformance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChartPerformance.Location = new System.Drawing.Point(0, 0);
            this.cartesianChartPerformance.Name = "cartesianChartPerformance";
            this.cartesianChartPerformance.Size = new System.Drawing.Size(3282, 495);
            this.cartesianChartPerformance.TabIndex = 47;
            this.cartesianChartPerformance.Text = "cartesianChart1";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tableLayoutPanel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(3282, 91);
            this.panel6.TabIndex = 51;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel3.Controls.Add(this.tlpPerformanceChartDaySkipperHolder, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.rdbPerformanceMax, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.rdbPerformanceFiveDays, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rdbPerformanceOneMonth, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.rdbPerformanceFiveYear, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.rdbPerformanceSixMonths, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.rdbPerformanceOneYear, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.rdbPerformanceYTD, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(3282, 91);
            this.tableLayoutPanel3.TabIndex = 51;
            // 
            // tlpPerformanceChartDaySkipperHolder
            // 
            this.tlpPerformanceChartDaySkipperHolder.ColumnCount = 2;
            this.tlpPerformanceChartDaySkipperHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.34266F));
            this.tlpPerformanceChartDaySkipperHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.65734F));
            this.tlpPerformanceChartDaySkipperHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPerformanceChartDaySkipperHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPerformanceChartDaySkipperHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPerformanceChartDaySkipperHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPerformanceChartDaySkipperHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPerformanceChartDaySkipperHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPerformanceChartDaySkipperHolder.Controls.Add(this.label3, 0, 0);
            this.tlpPerformanceChartDaySkipperHolder.Controls.Add(this.cmbSkipDaysForDataPoints, 1, 0);
            this.tlpPerformanceChartDaySkipperHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPerformanceChartDaySkipperHolder.Location = new System.Drawing.Point(2530, 3);
            this.tlpPerformanceChartDaySkipperHolder.Name = "tlpPerformanceChartDaySkipperHolder";
            this.tlpPerformanceChartDaySkipperHolder.RowCount = 1;
            this.tlpPerformanceChartDaySkipperHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPerformanceChartDaySkipperHolder.Size = new System.Drawing.Size(749, 85);
            this.tlpPerformanceChartDaySkipperHolder.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10);
            this.label3.Size = new System.Drawing.Size(423, 85);
            this.label3.TabIndex = 41;
            this.label3.Text = "Skip Days";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbSkipDaysForDataPoints
            // 
            this.cmbSkipDaysForDataPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSkipDaysForDataPoints.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSkipDaysForDataPoints.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSkipDaysForDataPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbSkipDaysForDataPoints.FormattingEnabled = true;
            this.cmbSkipDaysForDataPoints.ItemHeight = 80;
            this.cmbSkipDaysForDataPoints.Items.AddRange(new object[] {
            "0",
            "1",
            "5",
            "7",
            "15",
            "30"});
            this.cmbSkipDaysForDataPoints.Location = new System.Drawing.Point(432, 3);
            this.cmbSkipDaysForDataPoints.Name = "cmbSkipDaysForDataPoints";
            this.cmbSkipDaysForDataPoints.Size = new System.Drawing.Size(314, 86);
            this.cmbSkipDaysForDataPoints.TabIndex = 40;
            this.cmbSkipDaysForDataPoints.Text = "5";
            // 
            // rdbPerformanceMax
            // 
            this.rdbPerformanceMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbPerformanceMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbPerformanceMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPerformanceMax.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.rdbPerformanceMax.Location = new System.Drawing.Point(2169, 3);
            this.rdbPerformanceMax.Name = "rdbPerformanceMax";
            this.rdbPerformanceMax.Padding = new System.Windows.Forms.Padding(10);
            this.rdbPerformanceMax.Size = new System.Drawing.Size(355, 85);
            this.rdbPerformanceMax.TabIndex = 39;
            this.rdbPerformanceMax.Text = "Max.";
            this.rdbPerformanceMax.UseVisualStyleBackColor = true;
            // 
            // rdbPerformanceFiveDays
            // 
            this.rdbPerformanceFiveDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbPerformanceFiveDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbPerformanceFiveDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPerformanceFiveDays.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.rdbPerformanceFiveDays.Location = new System.Drawing.Point(3, 3);
            this.rdbPerformanceFiveDays.Name = "rdbPerformanceFiveDays";
            this.rdbPerformanceFiveDays.Padding = new System.Windows.Forms.Padding(10);
            this.rdbPerformanceFiveDays.Size = new System.Drawing.Size(355, 85);
            this.rdbPerformanceFiveDays.TabIndex = 33;
            this.rdbPerformanceFiveDays.Text = "5 T.";
            this.rdbPerformanceFiveDays.UseVisualStyleBackColor = true;
            // 
            // rdbPerformanceOneMonth
            // 
            this.rdbPerformanceOneMonth.Checked = true;
            this.rdbPerformanceOneMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbPerformanceOneMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbPerformanceOneMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPerformanceOneMonth.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.rdbPerformanceOneMonth.Location = new System.Drawing.Point(364, 3);
            this.rdbPerformanceOneMonth.Name = "rdbPerformanceOneMonth";
            this.rdbPerformanceOneMonth.Padding = new System.Windows.Forms.Padding(10);
            this.rdbPerformanceOneMonth.Size = new System.Drawing.Size(355, 85);
            this.rdbPerformanceOneMonth.TabIndex = 34;
            this.rdbPerformanceOneMonth.TabStop = true;
            this.rdbPerformanceOneMonth.Text = "1 M.";
            this.rdbPerformanceOneMonth.UseVisualStyleBackColor = true;
            // 
            // rdbPerformanceFiveYear
            // 
            this.rdbPerformanceFiveYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbPerformanceFiveYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbPerformanceFiveYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPerformanceFiveYear.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.rdbPerformanceFiveYear.Location = new System.Drawing.Point(1808, 3);
            this.rdbPerformanceFiveYear.Name = "rdbPerformanceFiveYear";
            this.rdbPerformanceFiveYear.Padding = new System.Windows.Forms.Padding(10);
            this.rdbPerformanceFiveYear.Size = new System.Drawing.Size(355, 85);
            this.rdbPerformanceFiveYear.TabIndex = 38;
            this.rdbPerformanceFiveYear.Text = "5 J.";
            this.rdbPerformanceFiveYear.UseVisualStyleBackColor = true;
            // 
            // rdbPerformanceSixMonths
            // 
            this.rdbPerformanceSixMonths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbPerformanceSixMonths.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbPerformanceSixMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPerformanceSixMonths.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.rdbPerformanceSixMonths.Location = new System.Drawing.Point(725, 3);
            this.rdbPerformanceSixMonths.Name = "rdbPerformanceSixMonths";
            this.rdbPerformanceSixMonths.Padding = new System.Windows.Forms.Padding(10);
            this.rdbPerformanceSixMonths.Size = new System.Drawing.Size(355, 85);
            this.rdbPerformanceSixMonths.TabIndex = 35;
            this.rdbPerformanceSixMonths.Text = "6 M.";
            this.rdbPerformanceSixMonths.UseVisualStyleBackColor = true;
            // 
            // rdbPerformanceOneYear
            // 
            this.rdbPerformanceOneYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbPerformanceOneYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbPerformanceOneYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPerformanceOneYear.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.rdbPerformanceOneYear.Location = new System.Drawing.Point(1447, 3);
            this.rdbPerformanceOneYear.Name = "rdbPerformanceOneYear";
            this.rdbPerformanceOneYear.Padding = new System.Windows.Forms.Padding(10);
            this.rdbPerformanceOneYear.Size = new System.Drawing.Size(355, 85);
            this.rdbPerformanceOneYear.TabIndex = 37;
            this.rdbPerformanceOneYear.Text = "1 J.";
            this.rdbPerformanceOneYear.UseVisualStyleBackColor = true;
            // 
            // rdbPerformanceYTD
            // 
            this.rdbPerformanceYTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbPerformanceYTD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbPerformanceYTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPerformanceYTD.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.rdbPerformanceYTD.Location = new System.Drawing.Point(1086, 3);
            this.rdbPerformanceYTD.Name = "rdbPerformanceYTD";
            this.rdbPerformanceYTD.Padding = new System.Windows.Forms.Padding(10);
            this.rdbPerformanceYTD.Size = new System.Drawing.Size(355, 85);
            this.rdbPerformanceYTD.TabIndex = 36;
            this.rdbPerformanceYTD.Text = "YTD";
            this.rdbPerformanceYTD.UseVisualStyleBackColor = true;
            // 
            // stockListPanel
            // 
            this.stockListPanel.AutoScroll = true;
            this.stockListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockListPanel.Location = new System.Drawing.Point(3, 3);
            this.stockListPanel.Name = "stockListPanel";
            this.stockListPanel.Size = new System.Drawing.Size(3284, 1405);
            this.stockListPanel.TabIndex = 3;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(7680, 2186);
            this.Controls.Add(this.tlpOverallLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.Text = "FlowBank Extended";
            this.tlpOverallLayout.ResumeLayout(false);
            this.tlpOverallLayout.PerformLayout();
            this.tlpMenuBar.ResumeLayout(false);
            this.tlpMenuLeft.ResumeLayout(false);
            this.pnlDrag.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnlMainView.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabMainWindow.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tlpStockPanelHolder.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tlpPerformanceChartDaySkipperHolder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpOverallLayout;
        private System.Windows.Forms.TableLayoutPanel tlpMenuBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlDrag;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlMainView;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.ComboBox cmbAccount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tlpMenuLeft;
        private System.Windows.Forms.Button btnMainView;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMainWindow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LiveCharts.WinForms.PieChart pieChartPositions;
        private System.Windows.Forms.TabPage tabPositionWindow;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnPositionDetails;
        private LiveCharts.WinForms.PieChart pieChart2;
        private System.Windows.Forms.Panel panel1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tlpStockPanelHolder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel5;
        private LiveCharts.WinForms.CartesianChart cartesianChartPerformance;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tlpPerformanceChartDaySkipperHolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSkipDaysForDataPoints;
        private System.Windows.Forms.RadioButton rdbPerformanceMax;
        private System.Windows.Forms.RadioButton rdbPerformanceFiveDays;
        private System.Windows.Forms.RadioButton rdbPerformanceOneMonth;
        private System.Windows.Forms.RadioButton rdbPerformanceFiveYear;
        private System.Windows.Forms.RadioButton rdbPerformanceSixMonths;
        private System.Windows.Forms.RadioButton rdbPerformanceOneYear;
        private System.Windows.Forms.RadioButton rdbPerformanceYTD;
        private System.Windows.Forms.Panel stockListPanel;
    }
}

