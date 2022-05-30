using AdvancedRepository.Models;
using AdvancedRepository.Models.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Core
{
    public class BaseRepository<T>: IBaseRepository<T> where T : class
    {
        CompanyContext _db;
        public BaseRepository(CompanyContext db)
        {
            _db = db;
        }

        public bool Create(T ent)
        {
            try
            {
                
                Set().Add(ent);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Delete(T ent)
        {
            try
            {
                
                Set().Remove(ent);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public T Find(int id)
        {
            return Set().Find(id);

        }

        public List<T> List()
        {
            return Set().ToList();
        }

        //public IQueryable<T> Qry()
        //{
        //    return List().AsQueryable();

        //}

        public void Recover(int id)
        {
            T entity = Set().Find(id);// firstordefault find metoduyla aynı.          
        }

        public List<T> RecoverList()
        {
            return Set().ToList();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public DbSet<T> Set()
        {
            return _db.Set<T>();
        }

        public bool Update(T ent)
        {
            try
            {
                
                Set().Update(ent);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
