using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingForTakingPills
{
    [Table("Категория")]
    public class Category
    {
        public int Id { get; set; }
        public string NameOfCategory { get; set; }
    }
}
