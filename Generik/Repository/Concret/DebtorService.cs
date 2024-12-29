using Generik.Models;
using Generik.Repository.Abstract;
using Generik.Repository.DbContect;

namespace Generik.Repository.Concret;
public class DebtorService : IDebtorService<Debtor>
{


    private readonly DataBase _database;

    public DebtorService(DataBase database)
    {
        _database = database;
    }

    public IEnumerable<Debtor> GetDebtorsAbleToFormSmileWord()
    {
        var debtors = _database.Debtors.ToList();
        var smileLetters = "smile".ToCharArray(); 

        var result = debtors.Where(d =>
        {
        
            var fullName = d.FullName.Replace(" ", "").ToLower();

      
            return smileLetters.All(letter => fullName.Contains(letter));
        });

     
        foreach (var debtor in result)
        {
            Console.WriteLine($"{debtor.FullName} - {debtor.Debt} AZN");
        }

        return result;
    }


    public IEnumerable<Debtor> GetDebtorsAbleToPayOffDebt()
    {
    var debtors = _database.Debtors.ToList();
    var result = debtors.Where(d =>
    {
        
        var monthlyPayment = 500;

        
        var monthsRequired = (double)d.Debt / monthlyPayment;

       
        var monthsUntilBirthday = (d.BirthDay.Month - DateTime.Today.Month + 12) % 12;  

       
        return monthsRequired <= monthsUntilBirthday;
    });

   
    foreach (var debtor in result)
    {
        Console.WriteLine($"{debtor.FullName} - {debtor.Debt} AZN - odeye biler");
    }

    return result;
}




    public IEnumerable<Debtor> GetDebtorsAboveAverageDebt(List<Debtor> debtors)
    {
        var averageDebt = debtors.Average(d => d.Debt);
        var result = debtors.Where(d => d.Debt > averageDebt)
                            .OrderBy(d => d.FullName.Split(' ').Last())
                            .ThenBy(d => d.Debt);

        foreach (var debtor in result)
        {
            Console.WriteLine($"{debtor.FullName} - {debtor.Debt} AZN");
        }

        return result;
    }


    public IEnumerable<Debtor> GetDebtorsBornInWinter()
    {
        var debtors = _database.Debtors.ToList();
        var result = debtors.Where(d => d.BirthDay.Month == 12 || d.BirthDay.Month <= 2);

        foreach (var debtor in result)
        {
            Console.WriteLine($"{debtor.FullName} - {debtor.BirthDay.ToShortDateString()}");
        }

        return result;
    }


    public IEnumerable<Debtor> GetDebtorsByAgeRange(int minAge, int maxAge)
    {
        var list = _database.Debtors.ToList();
        var result = list.Where(d =>
        {
            var today = DateTime.Today;
            
            var age = today.Year - d.BirthDay.Year;
            if (d.BirthDay.Date > today.AddYears(-age))
            {
                age--;
            }
            return age >= minAge && age <= maxAge;
        });
        return result;
    }

    public IEnumerable<Debtor> GetDebtorsByDebtAmount(int maxDebt)
    {
        var debtors = _database.Debtors.ToList();
        var result = debtors.Where(d => d.Debt <= maxDebt);

        
        foreach (var debtor in result)
        {
            Console.WriteLine($"{debtor.FullName} - {debtor.Debt} AZN");
        }

        return result;
    }



    public IEnumerable<Debtor> GetDebtorsByEmailDomain()
    {
        var list = _database.Debtors.ToList();
        var result = list.Where(d => d.Email.EndsWith("@rhyta.com") || d.Email.EndsWith("@dayrep.com"));

        
        return result;
    }

    public IEnumerable<Debtor> GetDebtorsByFullNameAndPhone(int nameLength = 18, int phoneDigit = 7, int requiredCount = 2)
    {
        var debtors = _database.Debtors.ToList();

        
        var result = debtors.Where(d =>
            d.FullName.Length > nameLength &&
            d.Phone.Where(char.IsDigit).Count(c => c == phoneDigit) >= requiredCount
        );
        foreach (var debtor in result)
        {
            Console.WriteLine($"{debtor.FullName} - {debtor.Phone}");
        }

        return result;

        
    }
    public IEnumerable<Debtor> GetDebtorsByPhoneNumberCondition()
    {
        var debtors = _database.Debtors.ToList();

       
        var result = debtors.Where(d => !d.Phone.Contains('8'))
                            .Select(d => new Debtor
                            {
                                FullName = d.FullName,
                                Debt = d.Debt,
                                BirthDay = d.BirthDay
                            });

   
        foreach (var debtor in result)
        {
            var age = DateTime.Today.Year - debtor.BirthDay.Year;
            if (debtor.BirthDay.Date > DateTime.Today.AddYears(-age)) age--; 
            Console.WriteLine($"{debtor.FullName.Split(' ').Last()} - {age} years - {debtor.Debt} AZN");
        }

        return result;
    }


    public IEnumerable<Debtor> GetDebtorsFromWW2()
    {
        var debtors = _database.Debtors.ToList();
        var result = debtors.Where(d => d.BirthDay.Year >= 1900 && d.BirthDay.Year <= 1945);

        foreach (var debtor in result)
        {
            Console.WriteLine($"{debtor.FullName} - {debtor.BirthDay.ToShortDateString()}");
        }

        return result;
    }


    public IEnumerable<Debtor> GetDebtorsWithTripleLettersInName()
    {
        var debtors = _database.Debtors.ToList();
        var result = debtors.Where(d => d.FullName.GroupBy(c => c).Any(g => g.Count() >= 3))
                            .OrderBy(d => d.FullName);

        foreach (var debtor in result)
        {
            Console.WriteLine($"{debtor.FullName} - {debtor.Debt} AZN");
        }

        return result;
    }

    public IEnumerable<Debtor> GetDebtorsWithUniquePhoneNumber()
    {
        var debtors = _database.Debtors.ToList();
        var result = debtors.Where(d => d.Phone.Distinct().Count() == d.Phone.Length);

        foreach (var debtor in result)
        {
            Console.WriteLine($"{debtor.FullName} - {debtor.Phone} - {debtor.Debt} AZN");
        }

        return result;
    }


    public int GetMostCommonBirthYear(IEnumerable<Debtor> debtors)
    {
        var mostCommonYear = debtors.GroupBy(d => d.BirthDay.Year)
                                    .OrderByDescending(g => g.Count())
                                    .First().Key;

        Console.WriteLine($"Most common birth year: {mostCommonYear}");
        return mostCommonYear;
    }


    public IEnumerable<Debtor> GetTop5HighestDebtDebtors(IEnumerable<Debtor> debtors)
    {
        var result = debtors.OrderByDescending(d => d.Debt).Take(5);

        foreach (var debtor in result)
        {
            Console.WriteLine($"{debtor.FullName} - {debtor.Debt} AZN");
        }

        return result;
    }


    public int GetTotalDebt(IEnumerable<Debtor> debtors)
    {
        var totalDebt = debtors.Sum(d => d.Debt);

        Console.WriteLine($"Butun borclar : {totalDebt} AZN");
        return totalDebt;
    }


}
