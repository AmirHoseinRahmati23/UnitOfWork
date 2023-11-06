using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Base;

namespace UnitOfWork_EFCore.Base
{
    public interface IRepository<T> where T : Entity
    {
        public IList<T> GetAll();
        public Task<IList<T>> GetAllAsync();

        public T? GetById(Guid id);
        public Task<T?> GetByIdAsync(Guid id);

        public void Insert(T entity);
        public Task InsertAsync(T entity);

        public void Update(T entity);
        public Task UpdateAsync(T entity);

        public void Delete(T entity);
        public Task DeleteAsync(T entity);

        public bool DeleteById(Guid id);
        public Task<bool> DeleteByIdAsync(Guid id);
    }
}
