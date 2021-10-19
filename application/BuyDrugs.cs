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
    public partial class BuyDrugs : Form
    {
        public BuyDrugs()
        {
            InitializeComponent();
        }

        private void FindDrugs(object sender, EventArgs e)
        {
            if (tbDrug.Text == "") { 
                MessageBox.Show("Пожалуйста, введите название лекарства", "Название лекарства", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; }

            string drug = tbDrug.Text;
            //открываем в браузере сайт с введённым лекарством
            System.Diagnostics.Process.Start($"https://apteka.ru/search/?q={drug}&page=1");
        }

        private void OpenShop(object sender, EventArgs e)
        {
            //открываем сайт
            System.Diagnostics.Process.Start("https://apteka.ru");
        }
    }
}
