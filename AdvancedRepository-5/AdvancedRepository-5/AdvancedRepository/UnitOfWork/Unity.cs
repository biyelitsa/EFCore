using AdvancedRepository.Models;
using AdvancedRepository.Repository.Classes;
using AdvancedRepository.Repository.Interfaces;

namespace AdvancedRepository.UnitOfWork
{
    public class Unity : IUnity
    {
        CompanyContext _db;
        
        public ICategoryRepository _catRepos { get; private set; }
        public ICityRepository _cityRepos { get; private set; }
        public ICountyRepository _countyRepos { get; private set; }
        public ICustomerRepository _customerRepos { get; private set; }
        public IEmployeeRepository _empRepos { get; private set; }
        public IProductRepository _proRepos { get; private set; }
        public ISupplierRepository _supRepos { get; private set; }
        public IUnitRepository _unitRepos { get; private set; }
        public IFatMasterRepository _fatRepos { get; private set; }

        public IFatDetailRepository _fatdetailRepos { get; private set; }

        public Unity(CompanyContext db)
        {
            _db = db;
            _catRepos = new CategoryRepository(db);
            _empRepos = new EmployeeRepository(db);
            _unitRepos = new UnitRepository(db);
            _supRepos = new SupplierRepository(db);
            _proRepos = new ProductRepository(db);
            _countyRepos = new CountyRepository(db);
            _cityRepos = new CityRepository(db);
            _customerRepos = new CustomerRepository(db);
            _fatRepos = new FatMasterRepository(db);
            _fatdetailRepos = new FatDetailRepository(db);
        }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
