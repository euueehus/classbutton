using System.Runtime.CompilerServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Click_1(object sender, EventArgs e)
        {
            label1.Text = "red";
            label1.BackColor = Color.Red ;
            pictureBox1.BackColor = Color.Red ;
            pictureBox1.BackgroundImage = Properties.Resources.Solid_red_svg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "green"; 
            label1.BackColor = Color.Green;
            pictureBox1.BackColor = Color.Green ;
            pictureBox1.BackgroundImage = Properties.Resources.¤U¸ü;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
