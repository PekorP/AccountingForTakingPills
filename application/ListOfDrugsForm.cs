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
    public partial class ListOfDrugsForm : Form
    {
        User user;
        public ListOfDrugsForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void DeleteDrugFromList(object sender, EventArgs e)
        {
            bool isDrugDeleteFromList;
            //проверка выбрано ли лекарство
            if ((lbListOfDrugs.SelectedIndex == -1) || (lbListOfDrugs.SelectedIndex == 0)) {
                MessageBox.Show("Error");
                return; }
            var drug = lbListOfDrugs.SelectedItem.ToString();
            DialogResult answer = MessageBox.Show($"Вы точно хотите удалить лекарство {drug} из списка?", "Подтверждение удаления лекарства",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
                isDrugDeleteFromList = WorkWithListOfDrugs.DeleteDrug(drug, user);
            else
                return;
            if (isDrugDeleteFromList == false)
                MessageBox.Show("Лекарство не удалось удалить из списка", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Лекарство удалено из списка лекарств!", "Удачное удаление лекарства из списка",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //обновляем список лекарств
                lbListOfDrugs.Items.Clear();
                lbListOfDrugs.Items.Add("Название лекарства");
                ListOfDrugsForm_Load(sender, e);
            }
        }

        private void ListOfDrugsForm_Load(object sender, EventArgs e)
        { 
            //получаем лекарства из списка
            var drugs = WorkWithListOfDrugs.ShowDrugs(user);
            if(drugs == null || drugs.Count == 0)
                MessageBox.Show("У Вас пока нет лекарств в списке", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                foreach(var drug in drugs)
                {
                    lbListOfDrugs.Items.Add(drug.Name);
                }
            }
            if(lbListOfDrugs.Items.Count != 1)
                lbListOfDrugs.SelectedIndex = 1;
        }

        private void ShowInfoAboutDrug(object sender, EventArgs e)
        {
            //получаем запись из списка лекарств и выводим информацию о выбранном лекарстве
            var drugName = lbListOfDrugs.SelectedItem.ToString();
            var drug = WorkWithListOfDrugs.GetDrug(drugName);
            var listOfDrugs = WorkWithListOfDrugs.GetListOfDrugs(user, drugName);
            if (drug == null || listOfDrugs == null)
                return;
            MessageBox.Show($"Название - {drug.Name}\nДата начала приёма - {listOfDrugs.DateOfBegin}\nДата окончания приёма\n" +
                $"{listOfDrugs.DateOfEnd}\nКоличество таблеток за приём - {listOfDrugs.CountOfDrugsPerUse}\nКоличество приёмов в день - " +
                $"{listOfDrugs.CountOfUsePerDay}", $"Информация о лекарстве {drug.Name}");
        }

        private void EditDrug(object sender, EventArgs e)
        {
            if ((lbListOfDrugs.SelectedIndex == -1) || (lbListOfDrugs.SelectedIndex == 0))
            {
                MessageBox.Show("Error");
                return;
            }
            //получаем запись из списка лекарств и передаём в форму редактирования лекарства, вызываем её
            var drugName = lbListOfDrugs.SelectedItem.ToString();
            var listOfDrugs = WorkWithListOfDrugs.GetListOfDrugs(user, drugName);
            EditDrugForm editDrug = new EditDrugForm(listOfDrugs, drugName);
            editDrug.Visible = true;
        }       

        private void AddDrugInList(object sender, EventArgs e)
        {
            //открытие формы добавления лекарства
            AddDrugForm addDrug = new AddDrugForm(user);
            addDrug.Visible = true;
            this.Close();
        }
    }
}
