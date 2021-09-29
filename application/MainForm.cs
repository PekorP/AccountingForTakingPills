using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingForTakingPills
{
    public partial class MainForm : Form
    {
        User user;
        public MainForm(User incommingUser)
        {
            InitializeComponent();
            user = incommingUser;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "м")
            {
                pictureBox1.Image = Properties.Resources.medsister;
            } if (textBox1.Text == "ж")
            {
                pictureBox1.Image = Properties.Resources.medbrother;
            }
            pictureBox1.Visible = true;
            if (textBox1.Text != "")
                System.Diagnostics.Process.Start($"https://apteka.ru/search/?q={textBox1.Text}&page=1");
            else
            {
                MessageBox.Show("Test");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"https://apteka.ru");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.Start.ToString().Substring(0,10));
            //MessageBox.Show(DateTime.Compare(DateTime.Today, new DateTime(2021,10,1)) + "");
        }
    }
}
