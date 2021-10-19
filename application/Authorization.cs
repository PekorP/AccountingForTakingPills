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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void EnterInTheSystem(object sender, EventArgs e)
        {
            if (tbLogin.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = new User() { Login = tbLogin.Text, Password = tbPassword.Text };
            User incommingUser = Authorization_class.Enter(user);
            //если пользователя нет в системе, то предлагаем зарегистрироваться (открываем форму регистрации)
            //при этом данные с формы входа логин и пароль переносятся на форму регистрации
            if (incommingUser.Id == 0)
            {
                DialogResult answer =  MessageBox.Show("Извините, но такого пользователя нет в системе. Желаете зарегистрироваться ?", "Ошибка входа",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {
                    Registration registration = new Registration(user.Login, user.Password);
                    registration.Visible = true;
                    this.Visible = false;
                    return;
                }
                //если не соглашаемся то очищаем поля
                else if (answer == DialogResult.No)
                {
                    tbLogin.Text = "";
                    tbPassword.Text = "";
                    return;
                }
            }

            //при успешном входе открываем главную форму
            MainForm mainForm = new MainForm(incommingUser);
            mainForm.Visible = true;
            this.Visible = false;
        }

        private void RegistrationInTheSystem(object sender, EventArgs e)
        {
            //открытие формы регистрации
            Registration registration = new Registration();
            registration.Visible = true;
            this.Visible = false;
        }

    }
}
