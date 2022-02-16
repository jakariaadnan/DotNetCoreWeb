using DotNetCore.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCore.Services.RepositoryService.Interfaces
{
    public interface IRepository<T> where T : Base
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
