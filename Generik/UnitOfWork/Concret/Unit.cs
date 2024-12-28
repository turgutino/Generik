using Generik.Repository.Concret;
using Generik.Repository.DbContect;

namespace Generik.UnitOfWork.Concret;
public class Unit
{
    public DataBase _database;

    public DebtorService DebtorService;

    public Unit() { }
    public Unit(DataBase database)
    {
        _database = database;
        DebtorService = new DebtorService(_database);
    }
}
