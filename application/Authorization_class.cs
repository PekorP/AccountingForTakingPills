using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingForTakingPills
{
    class Authorization_class
    {

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
                    var  isExistUser = db.Users.Where(u => u.Login == user.Login).Any();
                    if (isExistUser == true)
                        return new User();
                    db.Users.Add(user);
                    db.SaveChanges();
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
