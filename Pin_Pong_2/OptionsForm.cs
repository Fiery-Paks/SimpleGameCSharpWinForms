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
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            textBox_Pl.Text = MainForm.S_P.ToString();
            textBox_Ball.Text = MainForm.S_B.ToString();
            Save.ForeColor = Color.Green;
            Close.ForeColor = Color.Purple;
            label1.ForeColor = Color.Green;
            label2.ForeColor = Color.Purple;
            textBox_Pl.ForeColor = Color.Green;
            textBox_Ball.ForeColor = Color.Purple;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox_Ball.Text) <= 500 && Convert.ToInt32(textBox_Pl.Text) <= 20)
                {
                    MainForm.S_B = Convert.ToInt32(textBox_Ball.Text);
                    MainForm.S_P = Convert.ToInt32(textBox_Pl.Text);
                    MessageBox.Show("Saved");
                    Close();
                }
                else 
                {
                    MessageBox.Show("The entered numbers are too large !!!");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Invalid data format entered !!! \nThe correct data format is int.");
            }
        }
    }
}
