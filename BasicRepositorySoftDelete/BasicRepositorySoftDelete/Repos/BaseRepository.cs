using BasicRepositorySoftDelete.Models.Classes;
using BasicRepositorySoftDelete.Models.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepositorySoftDelete.Repos
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Base
    {
        PerContext _db;
        public BaseRepository(PerContext db)
        {
            _db = db;
        }
        public bool Create(T ent)
        {
            try
            {
                ent.Deleted = false;
                //_db.Entry(ent).State = EntityState.Added;
                Set().Add(ent);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public bool Delete(T ent)
        {
            // ent deleted kolonu true olarak gelecek.
            try
            {
                ent.Deleted = true;
                //_db.Entry(ent).State = EntityState.Added;
                Set().Update(ent);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool Recover(T ent)
        {
            // ent deleted kolonu true olarak gelecek.
            try
            {
                ent.Deleted = false;
                //_db.Entry(ent).State = EntityState.Added;
                Set().Update(ent);
                return false;
            }
            catch (Exception)
            {

                return true;
            }
        }


        public T Find(int id, bool deleted)
        {
            return Set().Where(x=> x.Deleted == deleted && x.Id == id).FirstOrDefault();

        }
      

        public List<T> List()
        {
            return Set().Where(x=> x.Deleted == false).ToList();
        }

        //public bool Recover(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Recover(int id)
        //{
        //    T ent = Set().Where(x => x.Deleted == true && x.Id == id).FirstOrDefault();
        //    ent.Deleted = false;

        //}
        public List<T> RecoverList()
        {
            return Set().Where(x => x.Deleted == true).ToList();
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
                //_db.Entry(ent).State = EntityState.Modified;
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
