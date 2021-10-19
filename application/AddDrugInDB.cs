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
    public partial class AddDrugInDB : Form
    {
        User user;
        public AddDrugInDB(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void bAddDrug_Click(object sender, EventArgs e)
        {
            string nameOfDrug = tbAddDrug.Text;
            if (nameOfDrug == "")
            {
                MessageBox.Show("Введите название лекарства", "Название лекарства",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var category = WorkWithListOfDrugs.GetCategories(cbCategory.SelectedItem.ToString());
            var isAddedDrug = WorkWithListOfDrugs.AddDrugInDB(nameOfDrug, category.Id);
            if (isAddedDrug == true)
            {
                MessageBox.Show("Лекарство добавлено в систему!", "Удачное добавление лекарства в систему",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                AddDrugForm addDrugForm = new AddDrugForm(user);
                addDrugForm.Visible = true;
                this.Close();
            }
        }

        private void AddDrugInDB_Load(object sender, EventArgs e)
        {
            //Добавление категорий в ComboBox
            tbAddDrug.Focus();
            var categories = WorkWithListOfDrugs.GetCategories();
            if (categories != null) {
                foreach (var category in categories)
                {
                    cbCategory.Items.Add(category.NameOfCategory);
                }
                cbCategory.SelectedIndex = 0;
            }
        }
    }
}
