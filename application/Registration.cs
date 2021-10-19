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
    public partial class Registration : Form
    {
        User user;
        public Registration()
        {
            InitializeComponent();
        }

        public Registration(string login, string password)
        {
            InitializeComponent(); 
            tbLogin.Text = login;
            tbPassword.Text = password;
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            rbSexM.Checked = true;
        }

        private void RegistrationInTheSystem(object sender, EventArgs e)
        {
            if (tbLogin.Text == "" || tbName.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            char sex = 'М';
            if (rbSexW.Checked == true)
                sex = 'Ж';
            user = Authorization_class.Registration(tbName.Text, tbLogin.Text, tbPassword.Text, sex);
            if (user.Id == 0)
            {
                MessageBox.Show("Пользователь с таким логином уже есть в системе, придумайте другой логин.",
                    "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            MainForm mainForm = new MainForm(user);
            mainForm.Visible = true;
            this.Visible = false;
        }
    }
}
