using System;
using System.Windows.Forms;

namespace Password_Gen
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            try
            {
                if (textBox1.Text == "")
                {
                    
                    f.Show();
                }
                textBox2.Text = quack.randomstring(Convert.ToInt32(textBox1.Text), checkBox1.Checked);
            }
            catch
            {
                f.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(textBox2.Text);
        }
    }

}
