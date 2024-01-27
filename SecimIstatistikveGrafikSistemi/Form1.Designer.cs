namespace SecimIstatistikveGrafikSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtIlceAdi = new TextBox();
            txtAParti = new TextBox();
            label2 = new Label();
            txtBParti = new TextBox();
            label3 = new Label();
            txtCParti = new TextBox();
            label4 = new Label();
            txtDParti = new TextBox();
            label5 = new Label();
            txtEParti = new TextBox();
            label6 = new Label();
            btnOyGirisi = new Button();
            btnCikis = new Button();
            btnGrafikler = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 0;
            label1.Text = "İlçe Adı:";
            // 
            // txtIlceAdi
            // 
            txtIlceAdi.Location = new Point(105, 6);
            txtIlceAdi.Margin = new Padding(4);
            txtIlceAdi.Name = "txtIlceAdi";
            txtIlceAdi.Size = new Size(233, 29);
            txtIlceAdi.TabIndex = 1;
            // 
            // txtAParti
            // 
            txtAParti.Location = new Point(105, 95);
            txtAParti.Margin = new Padding(4);
            txtAParti.Name = "txtAParti";
            txtAParti.Size = new Size(233, 29);
            txtAParti.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 2;
            label2.Text = "A Parti:";
            // 
            // txtBParti
            // 
            txtBParti.Location = new Point(105, 157);
            txtBParti.Margin = new Padding(4);
            txtBParti.Name = "txtBParti";
            txtBParti.Size = new Size(233, 29);
            txtBParti.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 160);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 4;
            label3.Text = "B Parti:";
            // 
            // txtCParti
            // 
            txtCParti.Location = new Point(105, 219);
            txtCParti.Margin = new Padding(4);
            txtCParti.Name = "txtCParti";
            txtCParti.Size = new Size(233, 29);
            txtCParti.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 222);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 6;
            label4.Text = "C Parti:";
            // 
            // txtDParti
            // 
            txtDParti.Location = new Point(105, 281);
            txtDParti.Margin = new Padding(4);
            txtDParti.Name = "txtDParti";
            txtDParti.Size = new Size(233, 29);
            txtDParti.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 284);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 8;
            label5.Text = "D Parti:";
            // 
            // txtEParti
            // 
            txtEParti.Location = new Point(105, 343);
            txtEParti.Margin = new Padding(4);
            txtEParti.Name = "txtEParti";
            txtEParti.Size = new Size(233, 29);
            txtEParti.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 346);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 10;
            label6.Text = "E Parti:";
            // 
            // btnOyGirisi
            // 
            btnOyGirisi.Location = new Point(13, 400);
            btnOyGirisi.Name = "btnOyGirisi";
            btnOyGirisi.Size = new Size(325, 54);
            btnOyGirisi.TabIndex = 12;
            btnOyGirisi.Text = "Oy Girişi Yap";
            btnOyGirisi.UseVisualStyleBackColor = true;
            btnOyGirisi.Click += btnOyGirisi_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(13, 460);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(156, 54);
            btnCikis.TabIndex = 13;
            btnCikis.Text = "Çıkış Yap";
            btnCikis.UseVisualStyleBackColor = true;
            // 
            // btnGrafikler
            // 
            btnGrafikler.Location = new Point(175, 460);
            btnGrafikler.Name = "btnGrafikler";
            btnGrafikler.Size = new Size(163, 54);
            btnGrafikler.TabIndex = 14;
            btnGrafikler.Text = "Grafikler";
            btnGrafikler.UseVisualStyleBackColor = true;
            btnGrafikler.Click += btnGrafikler_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(364, 526);
            Controls.Add(btnGrafikler);
            Controls.Add(btnCikis);
            Controls.Add(btnOyGirisi);
            Controls.Add(txtEParti);
            Controls.Add(label6);
            Controls.Add(txtDParti);
            Controls.Add(label5);
            Controls.Add(txtCParti);
            Controls.Add(label4);
            Controls.Add(txtBParti);
            Controls.Add(label3);
            Controls.Add(txtAParti);
            Controls.Add(label2);
            Controls.Add(txtIlceAdi);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIlceAdi;
        private TextBox txtAParti;
        private Label label2;
        private TextBox txtBParti;
        private Label label3;
        private TextBox txtCParti;
        private Label label4;
        private TextBox txtDParti;
        private Label label5;
        private TextBox txtEParti;
        private Label label6;
        private Button btnOyGirisi;
        private Button btnCikis;
        private Button btnGrafikler;
    }
}