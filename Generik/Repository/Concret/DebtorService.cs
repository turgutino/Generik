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
        throw new NotImplementedException();
    }

    public IEnumerable<Debtor> GetDebtorsAbleToPayOffDebt()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Debtor> GetDebtorsAboveAverageDebt(List<Debtor> debtors)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Debtor> GetDebtorsBornInWinter()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Debtor> GetDebtorsByAgeRange(int minAge, int maxAge)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Debtor> GetDebtorsByDebtAmount(int maxDebt)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Debtor> GetDebtorsByEmailDomain(string domain)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Debtor> GetDebtorsByFullNameAndPhone(string fullName, string phonePattern)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Debtor> GetDebtorsByPhoneNumberCondition(string phonePattern)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Debtor> GetDebtorsFromWW2()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Debtor> GetDebtorsWithTripleLettersInName()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Debtor> GetDebtorsWithUniquePhoneNumber()
    {
        throw new NotImplementedException();
    }

    public int GetMostCommonBirthYear(IEnumerable<Debtor> debtors)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Debtor> GetTop5HighestDebtDebtors(IEnumerable<Debtor> debtors)
    {
        throw new NotImplementedException();
    }

    public int GetTotalDebt(IEnumerable<Debtor> debtors)
    {
        throw new NotImplementedException();
    }
}
