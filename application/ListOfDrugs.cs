using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingForTakingPills
{
    [Table("СписокЛекарств")]
    public class ListOfDrugs
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DrugId { get; set; }
        public string DateOfBegin { get; set; }
        public string DateOfEnd { get; set; }
        public int CountOfDrugsPerUse { get; set; }
        public int CountOfUsePerDay { get; set; }
        public int TotalCountOfDrugsPerCourse { get; set; }
    }
}
