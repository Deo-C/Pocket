namespace Pocket
{
    partial class Form2
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
            button2 = new Button();
            button1 = new Button();
            button5 = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(127, 12);
            button2.Name = "button2";
            button2.Size = new Size(110, 29);
            button2.TabIndex = 0;
            button2.Text = "Bilgi";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(11, 12);
            button1.Name = "button1";
            button1.Size = new Size(110, 29);
            button1.TabIndex = 1;
            button1.Text = "Ana Menü";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(243, 12);
            button5.Name = "button5";
            button5.Size = new Size(110, 29);
            button5.TabIndex = 4;
            button5.Text = "Düzenle";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Yazdıklarınız Burda Gözükür." });
            listBox1.Location = new Point(27, 80);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(229, 454);
            listBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(292, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 27);
            textBox1.TabIndex = 7;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 10.8F);
            button7.Location = new Point(321, 204);
            button7.Name = "button7";
            button7.Size = new Size(109, 64);
            button7.TabIndex = 9;
            button7.Text = "Ara";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 10.8F);
            button8.Location = new Point(436, 204);
            button8.Name = "button8";
            button8.Size = new Size(109, 64);
            button8.TabIndex = 9;
            button8.Text = "Ekle";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 10.8F);
            button9.Location = new Point(321, 274);
            button9.Name = "button9";
            button9.Size = new Size(109, 64);
            button9.TabIndex = 9;
            button9.Text = "Sil";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 10.8F);
            button10.Location = new Point(436, 274);
            button10.Name = "button10";
            button10.Size = new Size(109, 64);
            button10.TabIndex = 9;
            button10.Text = "Düzenle";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(437, 537);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 10;
            label1.Text = "11.11.1111 11.11";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(292, 95);
            label2.Name = "label2";
            label2.Size = new Size(99, 38);
            label2.TabIndex = 11;
            label2.Text = "Pocket";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(293, 372);
            label3.Name = "label3";
            label3.Size = new Size(141, 31);
            label3.TabIndex = 10;
            label3.Text = "Hoşgeldiniz!";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 571);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(button2);
            ForeColor = SystemColors.ActiveCaptionText;
            MaximizeBox = false;
            Name = "Form2";
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            Shown += Form2_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button button5;
        private ListBox listBox1;
        private TextBox textBox1;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}