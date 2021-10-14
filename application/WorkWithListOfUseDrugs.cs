using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingForTakingPills
{
    class WorkWithListOfUseDrugs
    {
        internal static List<ListOfUseDrugs> GetRowsOfUse(string date, User user)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var listOfUse = db.ListsOfUseDrugs
                        .Where(l => l.DateOfUseDrug == date && l.UserId == user.Id).ToList();
                    return listOfUse;
                }
                catch (Exception e) { return null; }
            }
        }

        internal static int GetCountOfUseDrug(string date, int drugId, User user)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var count = db.ListsOfUseDrugs.Count(c => c.DateOfUseDrug == date && c.DrugId == drugId && c.UserId == user.Id);
                    return count;
                }
                catch (Exception e) { return 0; }
            }
        }

        internal static bool UseDrug(ListOfUseDrugs listUse, ListOfDrugs listDrugs)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                
                    db.ListsOfUseDrugs.Add(listUse);
                    WorkWithListOfDrugs.EditRowInList(listDrugs, listDrugs.UserId, listDrugs.DrugId);
                    db.SaveChanges();
                    return true;
                
            }
        }
    }
}
