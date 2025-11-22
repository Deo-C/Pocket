using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Pocket
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

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
            string date = DateTime.Now.ToString("dd.MM.yyyy H:mm");
            label1.Text = date;
        }

        private void button7_Click(object sender, EventArgs e) //Arama İşlemi
        {
            string name = textBox1.Text;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() == name)
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
                    if (i == listBox1.Items.Count - 1)
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
            if (listBox1.Items.Contains("Yazdıklarınız Burda Gözükür."))
            {
                listBox1.Items.Remove("Yazdıklarınız Burda Gözükür.");
            }
            label3.Text = "";
            string name = textBox1.Text;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() == name)
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

            if (!listBox1.Items.Contains(name))
            {
                listBox1.Items.Add(name);
            }
        }

        private void button9_Click(object sender, EventArgs e) //Silme İşlemi
        {
            string name = textBox1.Text;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() == name)
                {
                    listBox1.Items.Remove(name);
                    break;
                }
                if (i == listBox1.Items.Count - 1)
                {
                    if (listBox1.SelectedIndex != -1)
                    {
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
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
            if (listBox1.Items.Contains(dz))
            {
                int index = listBox1.Items.IndexOf(dz);
                string newName = Microsoft.VisualBasic.Interaction.InputBox("Seçili Yazıyı Düzenleyin : ", "Düzenle", dz);
                if (!string.IsNullOrWhiteSpace(newName))
                {
                    listBox1.Items[index] = newName;
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
    }
}
