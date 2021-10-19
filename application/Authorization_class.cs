using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingForTakingPills
{
    class Authorization_class
    {

        //Вход по логину и паролю
        public static User Enter(User us)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var user = db.Users.Where(u => u.Login == us.Login && u.Password == us.Password).First();
                    return user;
                }
                catch(Exception e)
                {
                    return new User();
                }
                
            } 
        }

        public static User Registration(string name, string login, string password, char sex)
        {
            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    User user = new User() { Name = name, Login = login, Password = password, Sex = sex };
                    //если пользователь с таким логином есть в базе, то return
                    var  isExistUser = db.Users.Where(u => u.Login == user.Login).Any();
                    if (isExistUser == true)
                        return new User();
                    db.Users.Add(user);
                    db.SaveChanges();
                    //добавляем пользователя в базу и возвращаем объект с данными
                    user = db.Users.Where(u => u.Login == user.Login && u.Password == user.Password).First();
                    return user;

                }
            }
            catch(Exception ex)
            {
                return new User();
            }

        }

    }
}
