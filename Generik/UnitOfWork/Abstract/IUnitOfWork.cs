using Generik.Models;
using Generik.Repository.Abstract;

namespace Generik.UnitOfWork.Abstract;
public interface IUnitOfWork
{
    public IDebtorService<Debtor> debtorService { get; }

}
