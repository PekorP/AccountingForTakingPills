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
            if(tbCountOfDrugsPerUse.Text == "" || tbCountOfUsePerDay.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listOfDrugs.DateOfBegin = lDateOfBegin.Text;
            listOfDrugs.DateOfEnd = lDateOfEnd.Text;
            listOfDrugs.CountOfDrugsPerUse = int.Parse(tbCountOfDrugsPerUse.Text);
            listOfDrugs.CountOfUsePerDay = int.Parse(tbCountOfUsePerDay.Text);
            listOfDrugs.UserId = user.Id;
            var drug = WorkWithListOfDrugs.GetDrug(lbListOfDrugs.SelectedItem.ToString());
            listOfDrugs.DrugId = drug.Id;
            var dayOfUse = (calDateOfEnd.SelectionStart - calDateOfBegin.SelectionStart).TotalDays;
            if (dayOfUse < 0)
            {
                MessageBox.Show("Дата окончания приёма не может быть меньше, чем дата начала приёма.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listOfDrugs.TotalCountOfDrugsPerCourse = (int)(dayOfUse+1) * listOfDrugs.CountOfDrugsPerUse * listOfDrugs.CountOfUsePerDay;
            var isAddedDrug = WorkWithListOfDrugs.AddDrugInList(listOfDrugs);
            if(isAddedDrug == true)
            {
                MessageBox.Show("Лекарство добавлено в список!", "Удачное добавление лекарства в список",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error");
            }
            ListOfDrugsForm l = new ListOfDrugsForm(user);
            l.Visible = true;
            this.Close();
        }

        private void tbFindDrug_TextChanged(object sender, EventArgs e)
        {
            lAddedDrug.Text = "Название добавляемого лекарства - ";
            lbListOfDrugs.Items.Clear();

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

        private void bAddDrugInDB_Click(object sender, EventArgs e)
        {
            AddDrugInDB addDrugDB = new AddDrugInDB(user);
            addDrugDB.Visible = true;
            this.Close();
        }
    }
}
