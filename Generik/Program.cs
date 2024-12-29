using Generik.Models;
using Generik.Repository.DbContect;
using Generik.UnitOfWork.Concret;
using Generik.UnitOfWork.Abstract;
using Generik.Repository.Concret;
using Generik.Repository.Abstract;

namespace Generik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DataBase db = new DataBase();
            
            Unit unit = new Unit(db);

            //1)
            //var smileDebtors = unit.DebtorService.GetDebtorsByEmailDomain();
            //Console.WriteLine("Rhyta.com və ya Dayrep.com Email Borclular:");
            //foreach (var debtor in smileDebtors)
            //{
            //    Console.WriteLine($"{debtor.FullName} - {debtor.Email}");
            //}

            //2)
            //var debtorsInAgeRange = unit.DebtorService.GetDebtorsByAgeRange(26, 36);

            //foreach (var debtor in debtorsInAgeRange)
            //{
            //    Console.WriteLine($"{debtor.FullName} - {debtor.BirthDay.ToShortDateString()} ({DateTime.Today.Year - debtor.BirthDay.Year} yaş)");
            //}

            //3)
            //unit.DebtorService.GetDebtorsByDebtAmount(5000);

            //unit.DebtorService.GetDebtorsByFullNameAndPhone();
            //unit.DebtorService.GetDebtorsBornInWinter();




            //unit.DebtorService.GetDebtorsAboveAverageDebt(db.Debtors);

            //unit.DebtorService.GetDebtorsByPhoneNumberCondition();

            //unit.DebtorService.GetDebtorsWithTripleLettersInName();

            //unit.DebtorService.GetDebtorsWithTripleLettersInName();

            //unit.DebtorService.GetMostCommonBirthYear(db.Debtors);

            //unit.DebtorService.GetTop5HighestDebtDebtors(db.Debtors);

            //unit.DebtorService.GetTotalDebt(db.Debtors);

            //unit.DebtorService.GetDebtorsFromWW2();

            //unit.DebtorService.GetDebtorsWithUniquePhoneNumber();

            //unit.DebtorService.GetDebtorsAbleToPayOffDebt();

            //unit.DebtorService.GetDebtorsAbleToFormSmileWord();


            

        }
    }
}
