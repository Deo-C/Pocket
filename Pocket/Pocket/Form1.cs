namespace Pocket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool onoff = Application.OpenForms["Form2"] != null;
            Form2 form2 = new Form2();
            string ad  = textBox1.Text + " " + DateTime.Now.ToString("dd.MM.yyyy") + " Pocket 1.0";
            form2.Text = ad;
            if (onoff)
            {
                MessageBox.Show("Hali Hazýrda Bir Liste Açýk.", "Pocket", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if(radioButton1.Checked)
            {
                form2.Show();
                this.Hide();
            }else
            {
                
            }
            
        }
    }
}
