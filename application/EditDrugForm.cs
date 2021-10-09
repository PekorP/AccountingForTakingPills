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
    public partial class EditDrugForm : Form
    {
        ListOfDrugs listOfDrugs;
        string drugName;
        public EditDrugForm(ListOfDrugs listOfDrugs, string drugName)
        {
            InitializeComponent();
            this.listOfDrugs = listOfDrugs;
            this.drugName = drugName;
        }

        private void EditDrugForm_Load(object sender, EventArgs e)
        {
            this.Text += $" {drugName}";
            lDrugName.Text += $" {drugName}";
            tbCountOfDrugsPerUse.Text = listOfDrugs.CountOfDrugsPerUse.ToString();
            tbCountOfUsePerDay.Text = listOfDrugs.CountOfUsePerDay.ToString();
            lDateOfBegin.Text = calDateOfBegin.SelectionStart.ToString().Substring(0, 10);
            lDateOfEnd.Text = calDateOfEnd.SelectionStart.ToString().Substring(0, 10);

            int dayDOB = int.Parse(listOfDrugs.DateOfBegin.Substring(0, 2));
            int monthDOB = int.Parse(listOfDrugs.DateOfBegin.Substring(3, 2));
            int yearDOB = int.Parse(listOfDrugs.DateOfBegin.Substring(6, 4));
            DateTime dateOfBegin = new DateTime(yearDOB, monthDOB, dayDOB);

            int dayDOE = int.Parse(listOfDrugs.DateOfEnd.Substring(0, 2));
            int monthDOE = int.Parse(listOfDrugs.DateOfEnd.Substring(3, 2));
            int yearDOE = int.Parse(listOfDrugs.DateOfEnd.Substring(6, 4));
            DateTime dateOfEnd = new DateTime(yearDOE, monthDOE, dayDOE);

            calDateOfBegin.SetDate(dateOfBegin);
            calDateOfEnd.SetDate(dateOfEnd);
        }

        private void calDateOfBegin_DateChanged(object sender, DateRangeEventArgs e)
        {
            lDateOfBegin.Text = calDateOfBegin.SelectionStart.ToString().Substring(0, 10);
        }

        private void calDateOfEnd_DateChanged(object sender, DateRangeEventArgs e)
        {
            lDateOfEnd.Text = calDateOfEnd.SelectionStart.ToString().Substring(0, 10);
        }

        private void SaveEdit(object sender, EventArgs e)
        {
            listOfDrugs.DateOfBegin = lDateOfBegin.Text;
            listOfDrugs.DateOfEnd = lDateOfEnd.Text;
            listOfDrugs.CountOfDrugsPerUse = int.Parse(tbCountOfDrugsPerUse.Text);
            listOfDrugs.CountOfUsePerDay = int.Parse(tbCountOfUsePerDay.Text);
            var dayOfUse = (calDateOfEnd.SelectionStart - calDateOfBegin.SelectionStart).TotalDays;
            if (dayOfUse < 0)
            {
                MessageBox.Show("Дата окончания приёма не может быть меньше, чем дата начала приёма.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listOfDrugs.TotalCountOfDrugsPerCourse = (int)dayOfUse * listOfDrugs.CountOfDrugsPerUse * listOfDrugs.CountOfUsePerDay;
            WorkWithListOfDrugs.EditRowInList(listOfDrugs, listOfDrugs.UserId, listOfDrugs.DrugId);
            MessageBox.Show("Данные успешно изменены", "Успех",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
