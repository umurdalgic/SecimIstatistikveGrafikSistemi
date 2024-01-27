namespace SecimIstatistikveGrafikSistemi
{
    partial class frmGrafikler
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
            groupBox1 = new GroupBox();
            chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            groupBox2 = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            progressBar5 = new ProgressBar();
            progressBar4 = new ProgressBar();
            progressBar3 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar1 = new ProgressBar();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chartControl1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(763, 240);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Grafikler";
            // 
            // chartControl1
            // 
            chartControl1.ChartArea.CursorLocation = new Point(0, 0);
            chartControl1.ChartArea.CursorReDraw = false;
            chartControl1.Dock = DockStyle.Fill;
            chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            chartControl1.Legend.Location = new Point(648, 75);
            chartControl1.Localize = null;
            chartControl1.Location = new Point(3, 22);
            chartControl1.Name = "chartControl1";
            chartControl1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            chartControl1.PrimaryXAxis.Margin = true;
            chartControl1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            chartControl1.PrimaryYAxis.Margin = true;
            chartControl1.Size = new Size(757, 215);
            chartControl1.TabIndex = 0;
            chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            chartControl1.Title.Name = "Default";
            chartControl1.Titles.Add(chartControl1.Title);
            chartControl1.VisualTheme = "";
            chartControl1.Click += chartControl1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(progressBar5);
            groupBox2.Controls.Add(progressBar4);
            groupBox2.Controls.Add(progressBar3);
            groupBox2.Controls.Add(progressBar2);
            groupBox2.Controls.Add(progressBar1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 258);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(539, 240);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "İlçe Değerleri";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(486, 163);
            label11.Name = "label11";
            label11.Size = new Size(18, 18);
            label11.TabIndex = 21;
            label11.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(486, 135);
            label10.Name = "label10";
            label10.Size = new Size(18, 18);
            label10.TabIndex = 20;
            label10.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(486, 112);
            label9.Name = "label9";
            label9.Size = new Size(18, 18);
            label9.TabIndex = 19;
            label9.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(486, 89);
            label8.Name = "label8";
            label8.Size = new Size(18, 18);
            label8.TabIndex = 18;
            label8.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(486, 66);
            label7.Name = "label7";
            label7.Size = new Size(18, 18);
            label7.TabIndex = 17;
            label7.Text = "0";
            // 
            // progressBar5
            // 
            progressBar5.BackColor = Color.DarkSeaGreen;
            progressBar5.ForeColor = SystemColors.ControlText;
            progressBar5.Location = new Point(80, 158);
            progressBar5.Maximum = 1000;
            progressBar5.Name = "progressBar5";
            progressBar5.Size = new Size(400, 23);
            progressBar5.TabIndex = 16;
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(80, 135);
            progressBar4.Maximum = 1000;
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(400, 23);
            progressBar4.TabIndex = 15;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(80, 112);
            progressBar3.Maximum = 1000;
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(400, 23);
            progressBar3.TabIndex = 14;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(80, 89);
            progressBar2.Maximum = 1000;
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(400, 23);
            progressBar2.TabIndex = 13;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.GreenYellow;
            progressBar1.ForeColor = SystemColors.ControlText;
            progressBar1.Location = new Point(80, 66);
            progressBar1.Maximum = 1000;
            progressBar1.MaximumSize = new Size(400, 23);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(400, 23);
            progressBar1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 163);
            label6.Name = "label6";
            label6.Size = new Size(57, 18);
            label6.TabIndex = 6;
            label6.Text = "E Parti";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 140);
            label5.Name = "label5";
            label5.Size = new Size(58, 18);
            label5.TabIndex = 5;
            label5.Text = "D Parti";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 117);
            label4.Name = "label4";
            label4.Size = new Size(57, 18);
            label4.TabIndex = 4;
            label4.Text = "C Parti";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 94);
            label3.Name = "label3";
            label3.Size = new Size(57, 18);
            label3.TabIndex = 3;
            label3.Text = "B Parti";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(58, 18);
            label2.TabIndex = 2;
            label2.Text = "A Parti";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(92, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 26);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 37);
            label1.Name = "label1";
            label1.Size = new Size(80, 18);
            label1.TabIndex = 0;
            label1.Text = "İlçe Seçin:";
            // 
            // frmGrafikler
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(785, 540);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmGrafikler";
            Text = "frmGrafikler";
            Load += frmGrafikler_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        public ProgressBar progressBar5;
        public ProgressBar progressBar4;
        public ProgressBar progressBar3;
        public ProgressBar progressBar2;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private ProgressBar progressBar1;
    }
}