using BasicRepositorySoftDelete.Models.Classes;
using BasicRepositorySoftDelete.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepositorySoftDelete.Repos
{
    public class PersonnelRepository : BaseRepository<Personnel>
    {
        PerContext _db;
        public PersonnelRepository(PerContext db) : base(db)
        {
            _db = db;
        }
    }
}
