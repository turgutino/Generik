namespace Generik.Repository.Abstract;
public interface IDebtorService<T>
{
    IEnumerable<T> GetDebtorsByEmailDomain();
    IEnumerable<T> GetDebtorsByAgeRange(int minAge, int maxAge);
    IEnumerable<T> GetDebtorsByDebtAmount(int maxDebt);
    IEnumerable<T> GetDebtorsByFullNameAndPhone(int nameLength = 18, int phoneDigit = 7, int requiredCount = 2);
    IEnumerable<T> GetDebtorsBornInWinter();
    IEnumerable<T> GetDebtorsAboveAverageDebt(List<T> debtors);
    IEnumerable<T> GetDebtorsByPhoneNumberCondition();
    IEnumerable<T> GetDebtorsWithTripleLettersInName();
    int GetMostCommonBirthYear(IEnumerable<T> debtors);
    IEnumerable<T> GetTop5HighestDebtDebtors(IEnumerable<T> debtors);
    int GetTotalDebt(IEnumerable<T> debtors);
    IEnumerable<T> GetDebtorsFromWW2();
    IEnumerable<T> GetDebtorsWithUniquePhoneNumber();
    IEnumerable<T> GetDebtorsAbleToPayOffDebt();
    IEnumerable<T> GetDebtorsAbleToFormSmileWord();
}
