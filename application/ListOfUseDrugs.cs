using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingForTakingPills
{
    [Table("СписокПриёмаЛекарств")]
    public class ListOfUseDrugs
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DrugId { get; set; }
        public string DateOfUseDrug { get; set; }
        public int CountOfUseDrugs { get; set; }
    }
}
 