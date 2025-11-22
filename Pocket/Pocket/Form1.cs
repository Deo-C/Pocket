using System.Runtime.InteropServices;


namespace Pocket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void button1_Click(object sender, EventArgs e)
        {
            bool onoff = Application.OpenForms["Form2"] != null;
            Form2 form2 = new Form2();
            string ad = textBox1.Text + " " + DateTime.Now.ToString("dd.MM.yyyy") + " Pocket 1.0";
            form2.Text = ad;
            Form3 form3 = new Form3();
            form3.Text = ad;
            if (onoff)
            {
                MessageBox.Show("Hali Hazýrda Bir Liste Açýk.", "Pocket", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioButton1.Checked)
            {
                form2.Show();
                this.Hide();
            }
            else if(radioButton2.Checked)
            {
                
                form3.Show();
                this.Hide();
            }
            else 
            {

            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
