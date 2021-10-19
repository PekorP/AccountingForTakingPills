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
                    //удаляем из списка лекарств запись с выбранным лекарством
                    db.ListsOfDrugs.Remove(drugInList);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }

            }
        }

        public static bool AddDrugInDB(string nameOfDrug, int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    Drug drug = new Drug();
                    drug.Name = nameOfDrug;
                    drug.CategoryId = id;

                    db.Add(drug);
                    db.SaveChanges();
                    return true;

                } catch (Exception e) { return false; }
            }
        }

        public static List<Category> GetCategories()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {

                    var categories = db.Categories.ToList();
                    return categories;

                }
                catch (Exception e) { return null; }
            }
        }

        public static Category GetCategories(string nameOfCategory)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {

                    var category = db.Categories.Where(c => c.NameOfCategory == nameOfCategory).First();
                    return category;

                }
                catch (Exception e) { return null; }
            }
        }

        //получаем лекарства определенного пользователя (из его списка)
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

        public static bool AddDrugInList(ListOfDrugs listOfDrugs)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    db.ListsOfDrugs.Add(listOfDrugs);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        //получаем все лекарства из базы
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


        public static Drug GetDrug(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var drug = db.Drugs.Where(d => d.Id == id).First();
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
