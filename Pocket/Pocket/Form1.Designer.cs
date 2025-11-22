namespace Pocket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel1 = new Panel();
            buttonMin = new Button();
            buttonClose = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(312, 397);
            button1.Name = "button1";
            button1.Size = new Size(140, 47);
            button1.TabIndex = 0;
            button1.Text = "Oluştur";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(27, 151);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 1;
            label1.Text = "Liste Adı : ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 64, 64);
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.ForeColor = SystemColors.Control;
            textBox1.Location = new Point(126, 148);
            textBox1.MaxLength = 40;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 31);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(27, 205);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "Liste Türü : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(27, 23);
            label3.Name = "label3";
            label3.Size = new Size(211, 81);
            label3.TabIndex = 1;
            label3.Text = "Pocket";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI", 10.8F);
            radioButton1.Location = new Point(140, 205);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(137, 29);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Normal Liste ";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 10.8F);
            radioButton2.Location = new Point(293, 205);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(143, 29);
            radioButton2.TabIndex = 3;
            radioButton2.Text = "Kontrol Listesi";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(buttonMin);
            panel1.Controls.Add(buttonClose);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 42);
            panel1.TabIndex = 4;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // buttonMin
            // 
            buttonMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMin.FlatAppearance.BorderSize = 0;
            buttonMin.FlatStyle = FlatStyle.Flat;
            buttonMin.Image = (Image)resources.GetObject("buttonMin.Image");
            buttonMin.Location = new Point(398, 3);
            buttonMin.Name = "buttonMin";
            buttonMin.Size = new Size(39, 35);
            buttonMin.TabIndex = 0;
            buttonMin.UseVisualStyleBackColor = true;
            buttonMin.Click += buttonMin_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.Location = new Point(443, 3);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(39, 35);
            buttonClose.TabIndex = 0;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(485, 479);
            Controls.Add(panel1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Ana Menü";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Panel panel1;
        private Button buttonMin;
        private Button buttonClose;
    }
}
