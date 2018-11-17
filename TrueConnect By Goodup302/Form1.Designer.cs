namespace TrueConnect_By_Goodup302
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ConnectionLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBoxIp = new System.Windows.Forms.MaskedTextBox();
            this.bufferText = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxLoopTime = new System.Windows.Forms.MaskedTextBox();
            this.listPing = new System.Windows.Forms.ListBox();
            this.TextBoxMaxMs = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Timers.Timer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxMaxMs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectionLabel
            // 
            this.ConnectionLabel.AutoSize = true;
            this.ConnectionLabel.Location = new System.Drawing.Point(15, 366);
            this.ConnectionLabel.Name = "ConnectionLabel";
            this.ConnectionLabel.Size = new System.Drawing.Size(55, 13);
            this.ConnectionLabel.TabIndex = 0;
            this.ConnectionLabel.Text = "-- Result --";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxIp
            // 
            this.TextBoxIp.Location = new System.Drawing.Point(15, 103);
            this.TextBoxIp.Name = "TextBoxIp";
            this.TextBoxIp.Size = new System.Drawing.Size(100, 20);
            this.TextBoxIp.TabIndex = 2;
            this.TextBoxIp.Text = "192.168.1.36";
            // 
            // bufferText
            // 
            this.bufferText.Location = new System.Drawing.Point(15, 64);
            this.bufferText.Name = "bufferText";
            this.bufferText.Size = new System.Drawing.Size(100, 20);
            this.bufferText.TabIndex = 3;
            this.bufferText.Text = "32";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buffer Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Maximum latency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Loop Time";
            // 
            // TextBoxLoopTime
            // 
            this.TextBoxLoopTime.Location = new System.Drawing.Point(15, 142);
            this.TextBoxLoopTime.Name = "TextBoxLoopTime";
            this.TextBoxLoopTime.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLoopTime.TabIndex = 9;
            this.TextBoxLoopTime.Text = "10";
            // 
            // listPing
            // 
            this.listPing.FormattingEnabled = true;
            this.listPing.Location = new System.Drawing.Point(121, 15);
            this.listPing.Name = "listPing";
            this.listPing.Size = new System.Drawing.Size(164, 147);
            this.listPing.TabIndex = 11;
            // 
            // TextBoxMaxMs
            // 
            this.TextBoxMaxMs.Increment = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.TextBoxMaxMs.Location = new System.Drawing.Point(15, 25);
            this.TextBoxMaxMs.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.TextBoxMaxMs.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TextBoxMaxMs.Name = "TextBoxMaxMs";
            this.TextBoxMaxMs.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMaxMs.TabIndex = 12;
            this.TextBoxMaxMs.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(15, 304);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown2.TabIndex = 13;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart1.CausesValidation = false;
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(291, 12);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.Size = new System.Drawing.Size(874, 351);
            this.chart1.TabIndex = 15;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Yellow;
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.progressBar.Location = new System.Drawing.Point(15, 340);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(270, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.SynchronizingObject = this;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(121, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 147);
            this.listBox1.TabIndex = 17;
            // 
            // trackBar
            // 
            this.trackBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar.Location = new System.Drawing.Point(341, 366);
            this.trackBar.Name = "trackBar";
            this.trackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar.Size = new System.Drawing.Size(794, 45);
            this.trackBar.TabIndex = 18;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 516);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 551);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.TextBoxMaxMs);
            this.Controls.Add(this.listPing);
            this.Controls.Add(this.TextBoxLoopTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bufferText);
            this.Controls.Add(this.TextBoxIp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConnectionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TrueConnect";
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxMaxMs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConnectionLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox TextBoxIp;
        private System.Windows.Forms.MaskedTextBox bufferText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox TextBoxLoopTime;
        private System.Windows.Forms.ListBox listPing;
        private System.Windows.Forms.NumericUpDown TextBoxMaxMs;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Timers.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Button button2;
    }
}