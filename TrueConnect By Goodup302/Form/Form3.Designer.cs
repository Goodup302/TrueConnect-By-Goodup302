namespace TrueConnect_By_Goodup302
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "0,1");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "1,2");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "2,3");
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonForm1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.titleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.closeImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.labelBuffer = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.inputAdresse = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.inputTime = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.inputBuffer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.inputLatency = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonStart = new MaterialSkin.Controls.MaterialRaisedButton();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.listBoxSuccess = new System.Windows.Forms.ListBox();
            this.listBoxErrors = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeImage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panel3.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 10;
            this.bunifuElipse.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.buttonForm1);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.closeImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 45);
            this.panel1.TabIndex = 0;
            // 
            // buttonForm1
            // 
            this.buttonForm1.AutoSize = true;
            this.buttonForm1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonForm1.Depth = 0;
            this.buttonForm1.Location = new System.Drawing.Point(524, 5);
            this.buttonForm1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonForm1.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonForm1.Name = "buttonForm1";
            this.buttonForm1.Primary = false;
            this.buttonForm1.Size = new System.Drawing.Size(105, 36);
            this.buttonForm1.TabIndex = 10;
            this.buttonForm1.Text = "Open Beta V1";
            this.buttonForm1.UseVisualStyleBackColor = true;
            this.buttonForm1.Click += new System.EventHandler(this.buttonForm1_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Depth = 0;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.titleLabel.Location = new System.Drawing.Point(12, 12);
            this.titleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(195, 19);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "TrueConnect By Goodup302";
            // 
            // closeImage
            // 
            this.closeImage.BackColor = System.Drawing.Color.Transparent;
            this.closeImage.Image = ((System.Drawing.Image)(resources.GetObject("closeImage.Image")));
            this.closeImage.ImageActive = null;
            this.closeImage.Location = new System.Drawing.Point(766, 12);
            this.closeImage.Name = "closeImage";
            this.closeImage.Size = new System.Drawing.Size(22, 22);
            this.closeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeImage.TabIndex = 0;
            this.closeImage.TabStop = false;
            this.closeImage.Zoom = 20;
            this.closeImage.Click += new System.EventHandler(this.closeImage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialLabel5);
            this.panel2.Controls.Add(this.labelBuffer);
            this.panel2.Controls.Add(this.materialLabel3);
            this.panel2.Controls.Add(this.inputAdresse);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.inputTime);
            this.panel2.Controls.Add(this.inputBuffer);
            this.panel2.Controls.Add(this.inputLatency);
            this.panel2.Controls.Add(this.buttonStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 405);
            this.panel2.TabIndex = 1;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(8, 3);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(131, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "Maximum Latency";
            // 
            // labelBuffer
            // 
            this.labelBuffer.AutoSize = true;
            this.labelBuffer.Depth = 0;
            this.labelBuffer.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelBuffer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelBuffer.Location = new System.Drawing.Point(8, 72);
            this.labelBuffer.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelBuffer.Name = "labelBuffer";
            this.labelBuffer.Size = new System.Drawing.Size(81, 19);
            this.labelBuffer.TabIndex = 8;
            this.labelBuffer.Text = "Buffer Size";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(10, 134);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(81, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Loop Time";
            // 
            // inputAdresse
            // 
            this.inputAdresse.BorderColorFocused = System.Drawing.Color.Blue;
            this.inputAdresse.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputAdresse.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.inputAdresse.BorderThickness = 3;
            this.inputAdresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputAdresse.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.inputAdresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputAdresse.isPassword = false;
            this.inputAdresse.Location = new System.Drawing.Point(4, 239);
            this.inputAdresse.Margin = new System.Windows.Forms.Padding(4);
            this.inputAdresse.Name = "inputAdresse";
            this.inputAdresse.Size = new System.Drawing.Size(192, 30);
            this.inputAdresse.TabIndex = 6;
            this.inputAdresse.Text = "192.168.1.36";
            this.inputAdresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(47, 209);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(73, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Adress IP";
            // 
            // inputTime
            // 
            this.inputTime.Depth = 0;
            this.inputTime.Hint = "";
            this.inputTime.Location = new System.Drawing.Point(12, 156);
            this.inputTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputTime.Name = "inputTime";
            this.inputTime.PasswordChar = '\0';
            this.inputTime.SelectedText = "";
            this.inputTime.SelectionLength = 0;
            this.inputTime.SelectionStart = 0;
            this.inputTime.Size = new System.Drawing.Size(182, 23);
            this.inputTime.TabIndex = 3;
            this.inputTime.Text = "10";
            this.inputTime.UseSystemPasswordChar = false;
            // 
            // inputBuffer
            // 
            this.inputBuffer.Depth = 0;
            this.inputBuffer.Hint = "";
            this.inputBuffer.Location = new System.Drawing.Point(12, 94);
            this.inputBuffer.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputBuffer.Name = "inputBuffer";
            this.inputBuffer.PasswordChar = '\0';
            this.inputBuffer.SelectedText = "";
            this.inputBuffer.SelectionLength = 0;
            this.inputBuffer.SelectionStart = 0;
            this.inputBuffer.Size = new System.Drawing.Size(182, 23);
            this.inputBuffer.TabIndex = 2;
            this.inputBuffer.Text = "1024";
            this.inputBuffer.UseSystemPasswordChar = false;
            // 
            // inputLatency
            // 
            this.inputLatency.Depth = 0;
            this.inputLatency.Hint = "";
            this.inputLatency.Location = new System.Drawing.Point(12, 25);
            this.inputLatency.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputLatency.Name = "inputLatency";
            this.inputLatency.PasswordChar = '\0';
            this.inputLatency.SelectedText = "";
            this.inputLatency.SelectionLength = 0;
            this.inputLatency.SelectionStart = 0;
            this.inputLatency.Size = new System.Drawing.Size(180, 23);
            this.inputLatency.TabIndex = 1;
            this.inputLatency.Text = "1000";
            this.inputLatency.UseSystemPasswordChar = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Depth = 0;
            this.buttonStart.Location = new System.Drawing.Point(27, 340);
            this.buttonStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Primary = true;
            this.buttonStart.Size = new System.Drawing.Size(148, 37);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Transparent;
            this.chart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(3, 3);
            this.chart.Name = "chart";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.YValuesPerPoint = 2;
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(586, 238);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.progressBar);
            this.panel3.Controls.Add(this.materialLabel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(200, 359);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 91);
            this.panel3.TabIndex = 2;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Silver;
            this.progressBar.BorderRadius = 7;
            this.progressBar.Location = new System.Drawing.Point(203, 48);
            this.progressBar.MaximumValue = 100;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.LightSeaGreen;
            this.progressBar.Size = new System.Drawing.Size(190, 13);
            this.progressBar.TabIndex = 1;
            this.progressBar.Value = 59;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(51, 26);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(497, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(206, 343);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(591, 10);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialTabControl1.Location = new System.Drawing.Point(200, 89);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(600, 270);
            this.materialTabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Graphic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxErrors);
            this.tabPage2.Controls.Add(this.listBoxSuccess);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Statistics";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(200, 45);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(600, 38);
            this.materialTabSelector1.TabIndex = 4;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // listBoxSuccess
            // 
            this.listBoxSuccess.FormattingEnabled = true;
            this.listBoxSuccess.Location = new System.Drawing.Point(2, 3);
            this.listBoxSuccess.Name = "listBoxSuccess";
            this.listBoxSuccess.Size = new System.Drawing.Size(312, 238);
            this.listBoxSuccess.TabIndex = 0;
            // 
            // listBoxErrors
            // 
            this.listBoxErrors.FormattingEnabled = true;
            this.listBoxErrors.Location = new System.Drawing.Point(320, 3);
            this.listBoxErrors.Name = "listBoxErrors";
            this.listBoxErrors.Size = new System.Drawing.Size(269, 238);
            this.listBoxErrors.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputTime;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputBuffer;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputLatency;
        private MaterialSkin.Controls.MaterialRaisedButton buttonStart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox inputAdresse;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel labelBuffer;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private Bunifu.Framework.UI.BunifuImageButton closeImage;
        private MaterialSkin.Controls.MaterialLabel titleLabel;
        private Bunifu.Framework.UI.BunifuProgressBar progressBar;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialFlatButton buttonForm1;
        private System.Windows.Forms.ListBox listBoxErrors;
        private System.Windows.Forms.ListBox listBoxSuccess;
    }
}