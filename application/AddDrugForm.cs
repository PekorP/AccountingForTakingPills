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
            //создаём объект для добавления записи в БД (запись в списке лекарств)
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
            if (drugs == null || drugs.Count == 0)
            {
                MessageBox.Show("Error", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                namesOfDrugs = new string[drugs.Count];
                for(int i =0; i < drugs.Count; i++)
                {
                //получаем названия всех лекарств в базе
                    namesOfDrugs[i] = drugs[i].Name.ToString().ToLower();
                }
                //Отображаем лекарства в ListBox + название выбранного лекарства
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

            //инициализируем свойства выбранными значениями на форме
            listOfDrugs.DateOfBegin = lDateOfBegin.Text;
            listOfDrugs.DateOfEnd = lDateOfEnd.Text;
            listOfDrugs.CountOfDrugsPerUse = int.Parse(tbCountOfDrugsPerUse.Text);
            listOfDrugs.CountOfUsePerDay = int.Parse(tbCountOfUsePerDay.Text);
            listOfDrugs.UserId = user.Id;

            //инициализируем лекарство, если его ещё нет в списке
            var drug = WorkWithListOfDrugs.GetDrug(lbListOfDrugs.SelectedItem.ToString());
            var list = WorkWithListOfDrugs.GetListOfDrugs(user.Id, drug.Id);
            if(list != null)
            {
                MessageBox.Show("Это лекарство уже есть в Вашем списке!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listOfDrugs.DrugId = drug.Id;

            var dayOfUse = (calDateOfEnd.SelectionStart - calDateOfBegin.SelectionStart).TotalDays;
            if (dayOfUse < 0)
            {
                MessageBox.Show("Дата окончания приёма не может быть меньше, чем дата начала приёма.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //рассчитываем общее количество таблеток за курс (кол-во дней * кол-во таблеток за приём * кол-во приёмов в день)
            listOfDrugs.TotalCountOfDrugsPerCourse = (int)(dayOfUse+1) * listOfDrugs.CountOfDrugsPerUse * listOfDrugs.CountOfUsePerDay;
            var isAddedDrug = WorkWithListOfDrugs.AddDrugInList(listOfDrugs);
            //добавляем лекарство в список и проверяем успешно ли добавили
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
                //добавляем все лекарства из базы, если в строке поиска ничего нет
                lbListOfDrugs.Items.AddRange(namesOfDrugs);
            }
            else
            {
                //поиск лекарства, начинающегося с введённого в TextBox текста и добавление в ListBox
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
            //вызов формы добавления лекарства в базу
            AddDrugInDB addDrugDB = new AddDrugInDB(user);
            addDrugDB.Visible = true;
            this.Close();
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
