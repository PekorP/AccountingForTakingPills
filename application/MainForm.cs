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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // создаем два объекта User
                User user1 = new User { Name = "Tom",  Sex = 'М', Login = "asd",  Password = "asd"};
                Drug drug = new Drug { Name = "test", CategoryId = 1 };

                // добавляем их в бд
                db.Users.Add(user1);
                db.Drugs.Add(drug);
                db.SaveChanges();
                MessageBox.Show("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var users = db.Drugs.ToList();
                MessageBox.Show("Список объектов:");
                foreach (Drug u in users)
                {
                    MessageBox.Show($"{u.Id}.{u.Name} - {u.CategoryId}");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "м")
            {
                pictureBox1.Image = Properties.Resources.medsister;
            } if (textBox1.Text == "ж")
            {
                pictureBox1.Image = Properties.Resources.medbrother;
            }
            pictureBox1.Visible = true;
            if (textBox1.Text != "")
                System.Diagnostics.Process.Start($"https://apteka.ru/search/?q={textBox1.Text}&page=1");
            else
            {
                MessageBox.Show("Test");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"https://apteka.ru");
        }
    }
}
