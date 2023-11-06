using Models.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork_EFCore
{
    public class Repository<T> : Base.Repository<T> where T : Entity
    {
        internal Repository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        public override IList<T> GetAll()
        {
            var allEntities = DbSet.ToList();

            return allEntities;
        }

        public override async Task<IList<T>> GetAllAsync()
        {
            var allEntities = await DbSet.ToListAsync();

            return allEntities;
        }



        public override T? GetById(Guid id)
        {
            var entity = DbSet.Find(id);
            return entity;
        }

        public override async Task<T?> GetByIdAsync(Guid id)
        {
            var entity = await DbSet.FindAsync(id);
            return entity;
        }



        public override void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(paramName: nameof(entity).ToUpper());
            }

            DbSet.Add(entity);
        }

        public override async Task InsertAsync(T entity)
        {
            if (entity == null)
            {
                throw new System.ArgumentNullException(paramName: nameof(entity).ToUpper());
            }

            await DbSet.AddAsync(entity);
        }




        public override void Update(T entity)
        {
            if (entity == null)
            {
                throw new System.ArgumentNullException(paramName: nameof(entity).ToUpper());
            }

            DbSet.Update(entity);
        }

        public override async Task UpdateAsync(T entity)
        {
            if (entity == null)
            {
                throw new System.ArgumentNullException(paramName: nameof(entity).ToUpper());
            }

            await Task.Run(() =>
            {
                DbSet.Update(entity);
            });
        }



        public override void Delete(T entity)
        {
            if (entity == null)
            {
                throw new System.ArgumentNullException(paramName: nameof(entity).ToUpper());
            }

            DbSet.Remove(entity);
        }

        public override async Task DeleteAsync(T entity)
        {
            if (entity == null)
            {
                throw new System.ArgumentNullException(paramName: nameof(entity).ToUpper());
            }

            await Task.Run(() =>
            {
                DbSet.Remove(entity);
            });
        }



        public override bool DeleteById(Guid id)
        {
            var entity = GetById(id);
            if (entity == null)
            {
                return false;
            }

            Delete(entity);

            return true;
        }

        public override async Task<bool> DeleteByIdAsync(Guid id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
            {
                return false;
            }

            await DeleteAsync(entity);

            return true;

        }
    }
}
