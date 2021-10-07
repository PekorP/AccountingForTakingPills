using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingForTakingPills
{
    [Table("Пользователь")]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public char Sex { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
