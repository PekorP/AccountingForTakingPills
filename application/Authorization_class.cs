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

        public static User Registration()
        {
            return new User();
        }

    }
}
