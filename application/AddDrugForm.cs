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
    public partial class AddDrugForm : Form
    {
        ListOfDrugs listOfDrugs;
        Drug drug;
        User user;
        string[] namesOfDrugs;
        public AddDrugForm(User user)
        {
            InitializeComponent();
            this.user = user;
            listOfDrugs = new ListOfDrugs();
        }

        private void calDateOfBegin_DateChanged(object sender, DateRangeEventArgs e)
        {
            lDateOfBegin.Text = calDateOfBegin.SelectionStart.ToString().Substring(0, 10);
        }

        private void calDateOfEnd_DateChanged(object sender, DateRangeEventArgs e)
        {
            lDateOfEnd.Text = calDateOfEnd.SelectionStart.ToString().Substring(0, 10);
        }

        private void AddDrugForm_Load(object sender, EventArgs e)
        {
            
            lDateOfBegin.Text = calDateOfBegin.SelectionStart.ToString().Substring(0, 10);
            lDateOfEnd.Text = calDateOfEnd.SelectionStart.ToString().Substring(0, 10);
            this.Width = 1300;
            this.Height = 650;

            var drugs = WorkWithListOfDrugs.ShowDrugs();
            namesOfDrugs = new string[drugs.Count];
            for(int i =0; i < drugs.Count; i++)
            {
                namesOfDrugs[i] = drugs[i].Name.ToString().ToLower();
            }
            if (drugs == null || drugs.Count == 0)
            {
                MessageBox.Show("Error", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                lbListOfDrugs.Items.AddRange(namesOfDrugs);
                lbListOfDrugs.SelectedIndex = 0;
                lAddedDrug.Text = "Название добавляемого лекарства - ";
                lAddedDrug.Text += lbListOfDrugs.SelectedItem;
            }
            
        }

        private void AddDrug(object sender, EventArgs e)
        {
            listOfDrugs.DateOfBegin = lDateOfBegin.Text;
            listOfDrugs.DateOfEnd = lDateOfEnd.Text;
            listOfDrugs.CountOfDrugsPerUse = int.Parse(tbCountOfDrugsPerUse.Text);
            listOfDrugs.CountOfUsePerDay = int.Parse(tbCountOfUsePerDay.Text);
            listOfDrugs.UserId = user.Id;
            var dayOfUse = (calDateOfEnd.SelectionStart - calDateOfBegin.SelectionStart).TotalDays;
            if (dayOfUse < 0)
            {
                MessageBox.Show("Дата окончания приёма не может быть меньше, чем дата начала приёма.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listOfDrugs.TotalCountOfDrugsPerCourse = (int)dayOfUse * listOfDrugs.CountOfDrugsPerUse * listOfDrugs.CountOfUsePerDay;
        }

        private void tbFindDrug_TextChanged(object sender, EventArgs e)
        {
            lAddedDrug.Text = "Название добавляемого лекарства - ";
            lbListOfDrugs.Items.Clear();

            // Если есть текст -- фильтруем элементы, если нет -- добавляем все элементы.
            if (string.IsNullOrWhiteSpace(tbFindDrug.Text))
            {
                lbListOfDrugs.Items.AddRange(namesOfDrugs);
            }
            else
            {
                lbListOfDrugs.Items.AddRange(namesOfDrugs.Where(s => s.StartsWith(tbFindDrug.Text)).ToArray());
            }
            if (lbListOfDrugs.Items.Count != 0)
            {
                lbListOfDrugs.SelectedIndex = 0;
                lAddedDrug.Text = "Название добавляемого лекарства - ";
                lAddedDrug.Text += lbListOfDrugs.SelectedItem;
            }
        }

        private void lbListOfDrugs_SelectedIndexChanged(object sender, EventArgs e)
        {
            lAddedDrug.Text = "Название добавляемого лекарства - ";
            lAddedDrug.Text += lbListOfDrugs.SelectedItem;
        }
    }
}
