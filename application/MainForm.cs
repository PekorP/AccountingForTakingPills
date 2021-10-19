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
            //в зависимости от пола выводим картинку
            if (user.Sex.ToString().ToLower() == "м")
                pictureBox1.Image = Properties.Resources.medsister;
            else
                pictureBox1.Image = Properties.Resources.medbrother;
            pictureBox1.Visible = true;
            label1.Text += $"\n{user.Name}";
        }

        private void WorkWithListOfDrugs(object sender, EventArgs e)
        {
            ListOfDrugsForm listOfDrugs = new ListOfDrugsForm(user);
            listOfDrugs.Visible = true;
        }

        private void CheckUseOfDrugs(object sender, EventArgs e)
        {
            ListOfUseDrugsForm useDrugs = new ListOfUseDrugsForm(user);
            useDrugs.Visible = true;
        }

        private void BuyDrugs(object sender, EventArgs e)
        {
            BuyDrugs buyDrugs = new BuyDrugs();
            buyDrugs.Visible = true;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
