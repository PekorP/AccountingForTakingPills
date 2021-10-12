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
                row.КоличествоПриёмовВДень = WorkWithListOfUseDrugs.GetCountOfUseDrug(date, WorkWithListOfDrugs.GetDrug(item.DrugId).Id);
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
            ShowRowsOfUse();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            ShowRowsOfUse();
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