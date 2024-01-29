using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pin_Pong_2
{
    public partial class MainForm : Form
    {
        public static int S_B = 25;
        public static int S_P = 5;

        public static int WP = 0;
        public static int WG = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Super Ping Pong\n First MOK";
            label1.ForeColor = Color.Purple;
            Start_But.ForeColor = Color.Green;
            Options_But.ForeColor = Color.Green;
            infoBut.ForeColor = Color.Green;
        }

        private void Start_But_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Visible = false;
        }

        private void Options_But_Click(object sender, EventArgs e)
        {
            OptionsForm OF = new OptionsForm();
            OF.Show();
        }

        private void infoBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sometimes i pull on it so hard i rip the skin");
        }
    }
}
