using Generik.Models;
using Generik.Repository.DbContect;
using Generik.UnitOfWork.Concret;
using Generik.UnitOfWork.Abstract;
using Generik.Repository.Concret;

namespace Generik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DataBase db = new DataBase();
            
            Unit unit = new Unit(db);

            var man = unit.DebtorService.GetDebtorsAbleToFormSmileWord();
            var man2 = unit.DebtorService.GetDebtorsByAgeRange(3,4);
            var man3 = unit.DebtorService.GetDebtorsWithTripleLettersInName();

            //Buradan butun funksiyalara catmaq olur


        }
    }
}
