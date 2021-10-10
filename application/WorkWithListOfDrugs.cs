using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingForTakingPills
{
    public class WorkWithListOfDrugs
    {

        public static bool DeleteDrug(string NameOfDrug, User user)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var drug = db.Drugs.Where(d => d.Name == NameOfDrug).First();
                    if (drug.Id == 0)
                        return false;
                    var drugInList = db.ListsOfDrugs.Where(l => l.UserId == user.Id && l.DrugId == drug.Id).First();
                    if (drugInList.Id == 0)
                        return false;
                    db.ListsOfDrugs.Remove(drugInList);
                    db.SaveChanges();
                    DeleteDrugFromListOfUse(user, drug);
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }

            }
        }

        private static void DeleteDrugFromListOfUse(User user, Drug drug)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var listOfUse = db.ListsOfUseDrugs.Where(l => l.UserId == user.Id && l.DrugId == drug.Id);
                    if (listOfUse != null)
                    {
                        foreach (var row in listOfUse)
                        {
                            db.ListsOfUseDrugs.Remove(row);
                        }
                        db.SaveChanges();
                    }
                }
                catch(Exception e)
                { }
            }
        }

        public static List<Drug> ShowDrugs(User user)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var listofUserDrugs = new List<Drug>();
                    var drugs = db.ListsOfDrugs.Where(i => i.UserId == user.Id).ToList();
                    foreach (var drug in drugs)
                    {
                        listofUserDrugs.Add(db.Drugs.Where(d => d.Id == drug.DrugId).First());
                    }
                    return listofUserDrugs;
                }
                catch(Exception e)
                {
                    return null;
                }
            }
        }

        public static List<Drug> ShowDrugs()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var listofUserDrugs = new List<Drug>();
                    var drugs = db.Drugs.ToList();
                    foreach (var drug in drugs)
                    {
                        listofUserDrugs.Add(db.Drugs.Where(d => d.Id == drug.Id).First());
                    }
                    return listofUserDrugs;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public static Drug GetDrug(string drugName)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var drug = db.Drugs.Where(d => d.Name == drugName).First();
                    if (drug.Id == 0)
                        return null;
                    return drug;
                }
                catch (Exception e) { return null; }
            }
        }

        public static void EditRowInList(ListOfDrugs listOfDrugs, int userId, int drugId)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var oldList = GetListOfDrugs(userId, drugId);
                    oldList = listOfDrugs; 
                    db.Entry(oldList).State = EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception e) { }
            }
        }

        public static ListOfDrugs GetListOfDrugs(User user, string drugName)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var drug = GetDrug(drugName);
                    if (drug == null)
                        return null;
                    return db.ListsOfDrugs.Where(l => l.UserId == user.Id && l.DrugId == drug.Id).First();
                    
                }
                catch (Exception e) { return null; }
            }
        }

        public static ListOfDrugs GetListOfDrugs(int userId, int drugId)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    return db.ListsOfDrugs.Where(l => l.UserId == userId && l.DrugId == drugId).First();
                }
                catch (Exception e) { return null; }
            }
        }
    }
}
