﻿using System;
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
    }
}