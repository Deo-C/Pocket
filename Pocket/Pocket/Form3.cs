using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Pocket
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void Form2_FormClosed(object sender, FormClosedEventArgs e) //Çıkış İşlemi
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) //Geri Dönüş İşlemi
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            string dat = DateTime.Now.ToString("dd.MM.yyyy H:mm");
            label1.Text = dat;
            lblName.Text = this.Text;
        }

        private void button7_Click(object sender, EventArgs e) //Arama İşlemi
        {
            string name = textBox1.Text;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.Items[i].ToString() == name)
                {
                    if (name.Length <= 12)
                    {
                        label3.Text = name + " Bulundu";
                    }
                    else
                    {
                        MessageBox.Show(name + " Bulundu");
                    }
                    break;
                }
                else
                {
                    if (i == checkedListBox1.Items.Count - 1)
                    {
                        if (name.Length <= 12)
                        {
                            label3.Text = name + " Bulunamadı";
                        }
                        else
                        {
                            MessageBox.Show(name + " Bulunamadı");
                        }
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e) //Ekleme İşlemi
        {
            if (checkedListBox1.Items.Contains("Yazdıklarınız Burda Gözükür."))
            {
                checkedListBox1.Items.Remove("Yazdıklarınız Burda Gözükür.");
            }
            label3.Text = "";
            string name = textBox1.Text;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.Items[i].ToString() == name)
                {
                    if (name.Length <= 12)
                    {
                        label3.Text = name + " Listede Bulunuyor";

                    }
                    else
                    {
                        MessageBox.Show(name + " Listede Bulunuyor");
                    }
                    break;
                }

            }

            if (!checkedListBox1.Items.Contains(name))
            {
                checkedListBox1.Items.Add(name);
            }
        }

        private void button9_Click(object sender, EventArgs e) //Silme İşlemi
        {
            string name = textBox1.Text;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.Items[i].ToString() == name)
                {
                    checkedListBox1.Items.Remove(name);
                    break;
                }
                if (i == checkedListBox1.Items.Count - 1)
                {
                    if (checkedListBox1.SelectedIndex != -1)
                    {
                        checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
                        label3.Text = "";
                        break;
                    }
                    if (name.Length <= 12)
                    {
                        label3.Text = name + " Bulunamadı";
                    }
                    else
                    {
                        MessageBox.Show(name + " Bulunamadı");
                    }
                }

            }



        }

        private void button10_Click(object sender, EventArgs e) //Düzenleme İşlemi
        {
            string dz = textBox1.Text;
            if (checkedListBox1.Items.Contains(dz))
            {
                int index = checkedListBox1.Items.IndexOf(dz);
                string newName = Microsoft.VisualBasic.Interaction.InputBox("Seçili Yazıyı Düzenleyin : ", "Düzenle", dz);
                if (!string.IsNullOrWhiteSpace(newName))
                {
                    checkedListBox1.Items[index] = newName;
                }
            }
            else
            {
                if (dz.Length <= 12)
                {
                    label3.Text = dz + " Bulunamadı";
                }
                else
                {
                    MessageBox.Show(dz + " Bulunamadı");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e) //Başlık Değiştirme İşlemi
        {
            Form2 form2 = new Form2();
            string form2text = Microsoft.VisualBasic.Interaction.InputBox("Yeni İsim Girin:", "Düzenle");
            if (!string.IsNullOrWhiteSpace(form2text))
            {
                this.Text = form2text + " " + DateTime.Now.ToString("dd.MM.yyyy") + " Pocket 1.0";
            }
            lblName.Text = this.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dd.MM.yyyy H:mm");
            label1.Text = date;
            
        }
    }
}
