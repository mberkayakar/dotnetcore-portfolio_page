using AKARmpwebsite.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKARmpwebsite.DataAccess.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class, ITable, new()

    {
        List<TEntity> GetAll();

        TEntity GetByİd(int id);

        void insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
}
