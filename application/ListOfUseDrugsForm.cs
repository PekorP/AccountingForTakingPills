using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccountingForTakingPills
{
    public partial class ListOfUseDrugsForm : Form
    {
        User user;
        public ListOfUseDrugsForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        public void ShowRowsOfUse()
        {
            var rows = new List<RowOfListOfUseDrugs>();
            var date = monthCalendar1.SelectionStart.ToString().Substring(0, 10);
            var rowsOfUse = WorkWithListOfUseDrugs.GetRowsOfUse(date, user);
            foreach (var item in rowsOfUse)
            {
                var row = new RowOfListOfUseDrugs();
                row.Лекарство = WorkWithListOfDrugs.GetDrug(item.DrugId).Name;
                row.ДатаПриёма = item.DateOfUseDrug;
                row.КоличествоПриёмовВДень = WorkWithListOfUseDrugs.GetCountOfUseDrug(date, WorkWithListOfDrugs.GetDrug(item.DrugId).Id, user);
                row.КоличествоПринятыхТаблеток = item.CountOfUseDrugs;
                rows.Add(row);
            }
            if (rowsOfUse == null || rowsOfUse.Count == 0)
            {
                MessageBox.Show($"В этот день ({date}) у Вас нет принятых лекарств");
                dataGridView1.DataSource = null;
                return;
            }
            rows = rows.GroupBy(x => x.Лекарство).Select(x => x.First()).ToList();

            dataGridView1.DataSource = rows;
        }

        private void ListOfUseDrugsForm_Load(object sender, EventArgs e)
        {
            label1.Text = monthCalendar1.SelectionStart.ToString().Substring(0, 10);
            var drugs = WorkWithListOfDrugs.ShowDrugs(user);
            if (drugs == null || drugs.Count == 0)
                MessageBox.Show("У Вас пока нет лекарств в списке", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                
                foreach (var drug in drugs)
                {
                    var list = WorkWithListOfDrugs.GetListOfDrugs(user.Id, drug.Id);

                    int day = int.Parse(list.DateOfEnd.Substring(0, 2));
                    int month = int.Parse(list.DateOfEnd.Substring(3, 2));
                    int year = int.Parse(list.DateOfEnd.Substring(6, 4));
                    DateTime date = new DateTime(year, month, day);

                    if (monthCalendar1.SelectionStart.CompareTo(date) == 1)
                        WorkWithListOfDrugs.DeleteDrug(drug.Name, user);
                    else
                        lbDrugs.Items.Add(drug.Name);
                }
            }
            if (lbDrugs.Items.Count != 0)
                lbDrugs.SelectedIndex = 0;
            ShowRowsOfUse();
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            ShowRowsOfUse();
            label1.Text = monthCalendar1.SelectionStart.ToString().Substring(0, 10);
        }

        private void lbDrugs_SelectedIndexChanged(object sender, EventArgs e)
        {
            var drugName = lbDrugs.SelectedItem.ToString();
            var list = WorkWithListOfDrugs.GetListOfDrugs(user, drugName);
            var countOfDrugsPerUse = list.CountOfDrugsPerUse;
            var totalCountOfDrugs = list.TotalCountOfDrugsPerCourse;
            bUseDrug.Text = $"Принять {countOfDrugsPerUse} табл.";
        }

        private void UseDrug(object sender, EventArgs e)
        {
            ListOfUseDrugs listUse = new ListOfUseDrugs();
            listUse.DrugId = WorkWithListOfDrugs.GetDrug(lbDrugs.SelectedItem.ToString()).Id;
            listUse.UserId = user.Id;
            listUse.DateOfUseDrug = monthCalendar1.SelectionStart.ToString().Substring(0, 10);

            var listDrugs = WorkWithListOfDrugs.GetListOfDrugs(user, lbDrugs.SelectedItem.ToString());

            var dateB = DateTime.Parse(listDrugs.DateOfBegin);
            var dateE = DateTime.Parse(listDrugs.DateOfEnd);
            if (dateB > monthCalendar1.SelectionEnd || dateE < monthCalendar1.SelectionStart) {
                MessageBox.Show($"Дата начала приёма - {dateB}\nДата окончания приёма - {dateE}\nСегодняшняя дата - {monthCalendar1.SelectionStart}");
                return; }

            var countOfDrugsPerUse = listDrugs.CountOfDrugsPerUse;
            var totalCountOfDrugs = listDrugs.TotalCountOfDrugsPerCourse;

            if (WorkWithListOfUseDrugs.GetCountOfUseDrug(listUse.DateOfUseDrug, listUse.DrugId, user) >= listDrugs.CountOfUsePerDay)
            {
                MessageBox.Show($"Приём {lbDrugs.SelectedItem} на сегодня закончен", "Конец приёма", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listUse.CountOfUseDrugs = countOfDrugsPerUse;
            listDrugs.TotalCountOfDrugsPerCourse = totalCountOfDrugs - countOfDrugsPerUse;
            if (listDrugs.TotalCountOfDrugsPerCourse == 0)
            {
                MessageBox.Show($"Это был последний приём таблеток {lbDrugs.SelectedItem.ToString()}", $"Последний приём {lbDrugs.SelectedItem.ToString()}",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                WorkWithListOfDrugs.DeleteDrug(lbDrugs.SelectedItem.ToString(), user);
            }
            bool isUsed = WorkWithListOfUseDrugs.UseDrug(listUse, listDrugs);
            if(isUsed == true)
                MessageBox.Show($"{lbDrugs.SelectedItem.ToString()} успешно принят!", $"{lbDrugs.SelectedItem.ToString()}",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            lbDrugs.Items.Clear();
            ListOfUseDrugsForm_Load(sender, e);
        }
    }

    public class RowOfListOfUseDrugs
    {
        public string Лекарство { get; set; }
        public string ДатаПриёма { get; set; }
        public int КоличествоПринятыхТаблеток { get; set; }
        public int КоличествоПриёмовВДень { get; set; }

        
    }
}