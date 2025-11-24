namespace Pocket
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            panel1 = new Panel();
            button3 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            label4 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 42);
            panel1.TabIndex = 5;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(403, 3);
            button3.Name = "button3";
            button3.Size = new Size(39, 35);
            button3.TabIndex = 14;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(448, 3);
            button4.Name = "button4";
            button4.Size = new Size(39, 35);
            button4.TabIndex = 15;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(12, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(467, 123);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ekleme";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(363, 84);
            label2.TabIndex = 0;
            label2.Text = "Listenin Yanında Bulunan Yazı Kutusuna\r\nEklemek istediğiniz Elemanın Adını Yazıp\r\nEkle Butonuna Basarak Ekleyebilirsiniz.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(12, 177);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(467, 123);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Silme";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(413, 84);
            label3.TabIndex = 0;
            label3.Text = "Listeden Silmek istediğiniz Elemanı seçip veya \r\nYazı Kutusuna Elemanın adını yazıp \r\nSil tuşuna basarak Silebilirsiniz.";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.ForeColor = SystemColors.Control;
            groupBox3.Location = new Point(12, 306);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(467, 175);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Düzenleme";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(6, 23);
            label4.Name = "label4";
            label4.Size = new Size(411, 140);
            label4.TabIndex = 0;
            label4.Text = "Düzenlemek İstediğiniz Elemanı Listeden seçin\r\nveya Yazı Kutusuna Adını yazdıktan sonra \r\nDüzenle Butonuna tıklayın.\r\nElemanın yeni adını girdikten Sonra \r\nTamam Tuşuna Basıp İşlemi sonlandırın.\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 6;
            label1.Text = "Bilgi";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(490, 502);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            Text = "Form4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button4;
        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox2;
        private Label label3;
        private GroupBox groupBox3;
        private Label label4;
        private Label label1;
    }
}