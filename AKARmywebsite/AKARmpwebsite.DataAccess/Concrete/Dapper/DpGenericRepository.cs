 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AKARmpwebsite.DataAccess.Interfaces;
using AKARmpwebsite.Entities.Interfaces;

namespace AKARmpwebsite.DataAccess.Concrete.Dapper
{
    public class DpGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, ITable, new()

    {

        private readonly IDbconnection _dbconnection;

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetByİd(int id)
        {
            throw new NotImplementedException();
        }

        public void insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
