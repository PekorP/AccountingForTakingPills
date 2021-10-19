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
            //по сути DataSource для DataDridView
            var rows = new List<RowOfListOfUseDrugs>();

            //получаем записи приёма лекарств за определенную дату и у определенного пользователя
            var date = monthCalendar1.SelectionStart.ToString().Substring(0, 10);
            var rowsOfUse = WorkWithListOfUseDrugs.GetRowsOfUse(date, user);

            //проходимся по записям и добавляем их в DataSource (rows) для DataGridView
            foreach (var item in rowsOfUse)
            {
                var row = new RowOfListOfUseDrugs();
                row.Лекарство = WorkWithListOfDrugs.GetDrug(item.DrugId).Name;
                row.ДатаПриёма = item.DateOfUseDrug;
                //здесь хранится количество записей с определенной датой и лекарством
                //то есть если у нас 3 записи о приёме лекарства арбидол за 10.10.2021,
                //то количество приёмов за 10.10.2021 лекарства арбидол равно трём
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
            //оставляем только уникальные записи. Так как мы считаем количество приёмов за день по кол-ву записей,
            //то по сути у нас остается в rows лишние одинаковые записи
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
                    //получаем дату окончания приёма лекарства из списка лекарств
                    DateTime date = DateTime.Parse(list.DateOfEnd);
                    //если эта дата меньше, чем текущая дата, то лекарство удаляется из списка,
                    //т.к. принимать лекарства мы можем только в те дни, которые указаны в списке
                    if (monthCalendar1.SelectionStart.CompareTo(date) == 1)
                        WorkWithListOfDrugs.DeleteDrug(drug.Name, user);
                    else
                        //если всё в порядке, добавляем дату в список лекарств в ListBox
                        lbDrugs.Items.Add(drug.Name);
                }
            }
            if (lbDrugs.Items.Count != 0)
                lbDrugs.SelectedIndex = 0;
            //Выводим данные в DGV
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
            //определяем сколько за 1 раз (приём) пользователь должен принять таблеток
            //берём эту информацию из его списка
            bUseDrug.Text = $"Принять {countOfDrugsPerUse} табл.";
        }

        private void UseDrug(object sender, EventArgs e)
        {
            //создаём объект приёма лекарства (для записи о приёме в базе данных)
            //и инициализируем свойства
            ListOfUseDrugs listUse = new ListOfUseDrugs();
            listUse.DrugId = WorkWithListOfDrugs.GetDrug(lbDrugs.SelectedItem.ToString()).Id;
            listUse.UserId = user.Id;
            listUse.DateOfUseDrug = monthCalendar1.SelectionStart.ToString().Substring(0, 10);

            var listDrugs = WorkWithListOfDrugs.GetListOfDrugs(user, lbDrugs.SelectedItem.ToString());

            //проверяем, чтобы дата приёма лекарства была в диапазоне из списка лекарств
            var dateB = DateTime.Parse(listDrugs.DateOfBegin);
            var dateE = DateTime.Parse(listDrugs.DateOfEnd);
            if (dateB > monthCalendar1.SelectionEnd || dateE < monthCalendar1.SelectionStart) {
                MessageBox.Show($"Дата начала приёма - {dateB}\nДата окончания приёма - {dateE}\nСегодняшняя дата - {monthCalendar1.SelectionStart}");
                return; }

            var countOfDrugsPerUse = listDrugs.CountOfDrugsPerUse;
            var totalCountOfDrugs = listDrugs.TotalCountOfDrugsPerCourse;

            //проверяем количество приёмов за день, чтобы не принять больше раз, чем в списке
            if (WorkWithListOfUseDrugs.GetCountOfUseDrug(listUse.DateOfUseDrug, listUse.DrugId, user) >= listDrugs.CountOfUsePerDay)
            {
                MessageBox.Show($"Приём {lbDrugs.SelectedItem} на сегодня закончен", "Конец приёма", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listUse.CountOfUseDrugs = countOfDrugsPerUse;
            //при приёме удаляем количество принятых таблеток из общего кол-ва за курс
            listDrugs.TotalCountOfDrugsPerCourse = totalCountOfDrugs - countOfDrugsPerUse;
            //если мы пропили все таблетки (весь курс), то удаляем лекарство из списка
            if (listDrugs.TotalCountOfDrugsPerCourse == 0)
            {
                MessageBox.Show($"Это был последний приём таблеток {lbDrugs.SelectedItem.ToString()}", $"Последний приём {lbDrugs.SelectedItem.ToString()}",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                WorkWithListOfDrugs.DeleteDrug(lbDrugs.SelectedItem.ToString(), user);
            }
            //проверяем успех приёма
            bool isUsed = WorkWithListOfUseDrugs.UseDrug(listUse, listDrugs);
            if(isUsed == true)
                MessageBox.Show($"{lbDrugs.SelectedItem.ToString()} успешно принят!", $"{lbDrugs.SelectedItem.ToString()}",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            lbDrugs.Items.Clear();
            ListOfUseDrugsForm_Load(sender, e);
        }
    }

    //класс для вывода информации в человеческом виде на DGV
    public class RowOfListOfUseDrugs
    {
        public string Лекарство { get; set; }
        public string ДатаПриёма { get; set; }
        public int КоличествоПринятыхТаблеток { get; set; }
        public int КоличествоПриёмовВДень { get; set; }

        
    }
}