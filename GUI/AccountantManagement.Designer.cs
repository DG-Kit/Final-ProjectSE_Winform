namespace GUI
{
    partial class AccountantManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantManagement));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_welcome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_accDB = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bAccountant = new System.Windows.Forms.Button();
            this.bProduct = new System.Windows.Forms.Button();
            this.grdDB = new System.Windows.Forms.DataGridView();
            this.cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.bBack = new System.Windows.Forms.Button();
            this.panel_phone = new System.Windows.Forms.Panel();
            this.bBack2 = new System.Windows.Forms.Button();
            this.grdPhone = new System.Windows.Forms.DataGridView();
            this.pieChart3 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            this.pieChart2 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bExport = new System.Windows.Forms.Button();
            this.label_ER = new System.Windows.Forms.Label();
            this.bPrintERD = new System.Windows.Forms.Button();
            this.grd_ER = new System.Windows.Forms.DataGridView();
            this.bPrintER = new System.Windows.Forms.Button();
            this.label_ERD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grd_ERD = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel_accDB.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDB)).BeginInit();
            this.panel_phone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhone)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ERD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(269, 107);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(448, 31);
            label1.TabIndex = 0;
            label1.Text = "Select the dashboard want to see";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 567);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label_welcome);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(1008, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Unispace", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_welcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_welcome.Location = new System.Drawing.Point(298, 23);
            this.label_welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(333, 42);
            this.label_welcome.TabIndex = 2;
            this.label_welcome.Text = "Accountant Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel_accDB);
            this.tabPage2.Controls.Add(this.panel_phone);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(1008, 539);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DashBoard";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel_accDB
            // 
            this.panel_accDB.Controls.Add(this.panel1);
            this.panel_accDB.Controls.Add(this.grdDB);
            this.panel_accDB.Controls.Add(this.cartesianChart1);
            this.panel_accDB.Controls.Add(this.bBack);
            this.panel_accDB.Location = new System.Drawing.Point(0, 0);
            this.panel_accDB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_accDB.Name = "panel_accDB";
            this.panel_accDB.Size = new System.Drawing.Size(1005, 539);
            this.panel_accDB.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.bAccountant);
            this.panel1.Controls.Add(this.bProduct);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 536);
            this.panel1.TabIndex = 5;
            // 
            // bAccountant
            // 
            this.bAccountant.BackColor = System.Drawing.Color.IndianRed;
            this.bAccountant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAccountant.Location = new System.Drawing.Point(269, 191);
            this.bAccountant.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bAccountant.Name = "bAccountant";
            this.bAccountant.Size = new System.Drawing.Size(202, 64);
            this.bAccountant.TabIndex = 1;
            this.bAccountant.Text = "Accountant";
            this.bAccountant.UseVisualStyleBackColor = false;
            this.bAccountant.Click += new System.EventHandler(this.bAccountant_Click);
            // 
            // bProduct
            // 
            this.bProduct.BackColor = System.Drawing.Color.IndianRed;
            this.bProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bProduct.Location = new System.Drawing.Point(502, 191);
            this.bProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bProduct.Name = "bProduct";
            this.bProduct.Size = new System.Drawing.Size(215, 64);
            this.bProduct.TabIndex = 1;
            this.bProduct.Text = "Product";
            this.bProduct.UseVisualStyleBackColor = false;
            this.bProduct.Click += new System.EventHandler(this.bProduct_Click);
            // 
            // grdDB
            // 
            this.grdDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDB.Location = new System.Drawing.Point(7, 358);
            this.grdDB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grdDB.Name = "grdDB";
            this.grdDB.RowHeadersWidth = 60;
            this.grdDB.Size = new System.Drawing.Size(832, 171);
            this.grdDB.TabIndex = 2;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(7, 8);
            this.cartesianChart1.Margin = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(983, 343);
            this.cartesianChart1.TabIndex = 3;
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(868, 484);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(121, 40);
            this.bBack.TabIndex = 6;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click_1);
            // 
            // panel_phone
            // 
            this.panel_phone.Controls.Add(this.bBack2);
            this.panel_phone.Controls.Add(this.grdPhone);
            this.panel_phone.Controls.Add(this.pieChart3);
            this.panel_phone.Controls.Add(this.pieChart2);
            this.panel_phone.Location = new System.Drawing.Point(3, 3);
            this.panel_phone.Name = "panel_phone";
            this.panel_phone.Size = new System.Drawing.Size(1002, 533);
            this.panel_phone.TabIndex = 6;
            // 
            // bBack2
            // 
            this.bBack2.Location = new System.Drawing.Point(21, 6);
            this.bBack2.Name = "bBack2";
            this.bBack2.Size = new System.Drawing.Size(121, 40);
            this.bBack2.TabIndex = 7;
            this.bBack2.Text = "Back";
            this.bBack2.UseVisualStyleBackColor = true;
            this.bBack2.Click += new System.EventHandler(this.bBack2_Click);
            // 
            // grdPhone
            // 
            this.grdPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPhone.Location = new System.Drawing.Point(438, 6);
            this.grdPhone.Name = "grdPhone";
            this.grdPhone.RowHeadersWidth = 60;
            this.grdPhone.RowTemplate.Height = 25;
            this.grdPhone.Size = new System.Drawing.Size(563, 530);
            this.grdPhone.TabIndex = 2;
            // 
            // pieChart3
            // 
            this.pieChart3.InitialRotation = 0D;
            this.pieChart3.IsClockwise = true;
            this.pieChart3.Location = new System.Drawing.Point(21, 321);
            this.pieChart3.Margin = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.pieChart3.MaxAngle = 360D;
            this.pieChart3.Name = "pieChart3";
            this.pieChart3.Size = new System.Drawing.Size(398, 200);
            this.pieChart3.TabIndex = 1;
            this.pieChart3.Total = null;
            // 
            // pieChart2
            // 
            this.pieChart2.InitialRotation = 0D;
            this.pieChart2.IsClockwise = true;
            this.pieChart2.Location = new System.Drawing.Point(21, 61);
            this.pieChart2.Margin = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.pieChart2.MaxAngle = 360D;
            this.pieChart2.Name = "pieChart2";
            this.pieChart2.Size = new System.Drawing.Size(398, 236);
            this.pieChart2.TabIndex = 0;
            this.pieChart2.Total = null;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Size = new System.Drawing.Size(1008, 539);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Import";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Import Receipt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage4.Size = new System.Drawing.Size(1008, 539);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Export";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label_ER);
            this.panel2.Controls.Add(this.bPrintERD);
            this.panel2.Controls.Add(this.grd_ER);
            this.panel2.Controls.Add(this.bPrintER);
            this.panel2.Controls.Add(this.label_ERD);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.grd_ERD);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 543);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bExport);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1010, 541);
            this.panel3.TabIndex = 5;
            // 
            // bExport
            // 
            this.bExport.Location = new System.Drawing.Point(7, 6);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(155, 66);
            this.bExport.TabIndex = 0;
            this.bExport.Text = "Export";
            this.bExport.UseVisualStyleBackColor = true;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // label_ER
            // 
            this.label_ER.AutoSize = true;
            this.label_ER.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ER.Location = new System.Drawing.Point(401, 3);
            this.label_ER.Name = "label_ER";
            this.label_ER.Size = new System.Drawing.Size(152, 30);
            this.label_ER.TabIndex = 1;
            this.label_ER.Text = "Export Receipt";
            // 
            // bPrintERD
            // 
            this.bPrintERD.BackColor = System.Drawing.Color.Blue;
            this.bPrintERD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bPrintERD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bPrintERD.Location = new System.Drawing.Point(519, 460);
            this.bPrintERD.Name = "bPrintERD";
            this.bPrintERD.Size = new System.Drawing.Size(169, 50);
            this.bPrintERD.TabIndex = 3;
            this.bPrintERD.Text = "Print Export Receipt";
            this.bPrintERD.UseVisualStyleBackColor = false;
            this.bPrintERD.Click += new System.EventHandler(this.bPrintERD_Click);
            // 
            // grd_ER
            // 
            this.grd_ER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_ER.Location = new System.Drawing.Point(8, 36);
            this.grd_ER.Name = "grd_ER";
            this.grd_ER.RowTemplate.Height = 25;
            this.grd_ER.Size = new System.Drawing.Size(993, 172);
            this.grd_ER.TabIndex = 0;
            this.grd_ER.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_ER_CellClick);
            // 
            // bPrintER
            // 
            this.bPrintER.BackColor = System.Drawing.Color.Blue;
            this.bPrintER.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bPrintER.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bPrintER.Location = new System.Drawing.Point(340, 460);
            this.bPrintER.Name = "bPrintER";
            this.bPrintER.Size = new System.Drawing.Size(173, 50);
            this.bPrintER.TabIndex = 3;
            this.bPrintER.Text = "Print Export Receipt";
            this.bPrintER.UseVisualStyleBackColor = false;
            this.bPrintER.Click += new System.EventHandler(this.bPrintER_Click);
            // 
            // label_ERD
            // 
            this.label_ERD.AutoSize = true;
            this.label_ERD.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ERD.Location = new System.Drawing.Point(366, 211);
            this.label_ERD.Name = "label_ERD";
            this.label_ERD.Size = new System.Drawing.Size(222, 30);
            this.label_ERD.TabIndex = 1;
            this.label_ERD.Text = "Export Receipt Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose Your Export Receipt To Print: ";
            // 
            // grd_ERD
            // 
            this.grd_ERD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_ERD.Location = new System.Drawing.Point(8, 244);
            this.grd_ERD.Name = "grd_ERD";
            this.grd_ERD.RowTemplate.Height = 25;
            this.grd_ERD.Size = new System.Drawing.Size(993, 176);
            this.grd_ERD.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage5.Size = new System.Drawing.Size(1008, 539);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Receipt";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // AccountantManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 565);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AccountantManagement";
            this.Text = "AccountantManagement";
            this.Load += new System.EventHandler(this.AccountantManagement_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel_accDB.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDB)).EndInit();
            this.panel_phone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPhone)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ERD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label_welcome;
        private Panel panel_phone;
        private DataGridView grdPhone;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart3;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart2;
        private Panel panel_accDB;
        private Panel panel1;
        private Button bAccountant;
        private Button bProduct;
        private DataGridView grdDB;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Button bBack;
        private Button bBack2;
        private Label label_ER;
        private Label label_ERD;
        private DataGridView grd_ERD;
        private DataGridView grd_ER;
        private Button bPrintERD;
        private Button bPrintER;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Button bExport;
        private Button button1;
    }
}

