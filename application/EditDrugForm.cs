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
            //изменяем навзание формы и заполняем данными из списка лекарств остальные элементы
            this.Text += $" {drugName}";
            lDrugName.Text += $" {drugName}";

            tbCountOfDrugsPerUse.Text = listOfDrugs.CountOfDrugsPerUse.ToString();
            tbCountOfUsePerDay.Text = listOfDrugs.CountOfUsePerDay.ToString();

            lDateOfBegin.Text = calDateOfBegin.SelectionStart.ToString().Substring(0, 10);
            lDateOfEnd.Text = calDateOfEnd.SelectionStart.ToString().Substring(0, 10);

            calDateOfBegin.SetDate(DateTime.Parse(listOfDrugs.DateOfBegin));
            calDateOfEnd.SetDate(DateTime.Parse(listOfDrugs.DateOfEnd));
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
            if (tbCountOfDrugsPerUse.Text == "" || tbCountOfUsePerDay.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //изменяем свойства, беря информацию с элементов формы
            listOfDrugs.DateOfBegin = lDateOfBegin.Text;
            listOfDrugs.DateOfEnd = lDateOfEnd.Text;
            listOfDrugs.CountOfDrugsPerUse = int.Parse(tbCountOfDrugsPerUse.Text);
            listOfDrugs.CountOfUsePerDay = int.Parse(tbCountOfUsePerDay.Text);

            //проверяем не больше ли дата начала даты окончания
            var dayOfUse = (calDateOfEnd.SelectionStart - calDateOfBegin.SelectionStart).TotalDays;
            if (dayOfUse < 0)
            {
                MessageBox.Show("Дата окончания приёма не может быть меньше, чем дата начала приёма.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //рассчитываем общее количество таблеток за курс (кол-во дней * кол-во таблеток за приём * кол-во приёмов в день)
            listOfDrugs.TotalCountOfDrugsPerCourse = (int)(dayOfUse + 1) * listOfDrugs.CountOfDrugsPerUse * listOfDrugs.CountOfUsePerDay;
            WorkWithListOfDrugs.EditRowInList(listOfDrugs, listOfDrugs.UserId, listOfDrugs.DrugId);
            MessageBox.Show("Данные успешно изменены", "Успех",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbCountOfDrugsPerUse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void tbCountOfUsePerDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
