﻿using BasicRepositorySoftDelete.Models.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepositorySoftDelete.Repos
{
    interface IBaseRepository<T> where T : Base
    {
        bool Update(T ent);
        bool Create(T ent);
        bool Delete(T ent);
        T Find(int id, bool deleted);
        List<T> List();
        List<T> RecoverList();
        void Save();
        DbSet<T> Set();
        bool Recover(T ent);
        //void Recover(int id);
    }
}
