using Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork_EFCore.Tools;

namespace UnitOfWork_EFCore.Base
{
    public class UnitOfWork : object, IUnitOfWork
    {
        public UnitOfWork(Options options)
        {
            Options = options;
        }
        protected Options Options { get; set; }

        private DatabaseContext? _databaseContext;
        internal DatabaseContext DatabaseContext 
        {
            get
            {
                if(_databaseContext == null)
                {
                    _databaseContext = new DatabaseContext();
                }
                return _databaseContext;
            }
        }

        public bool IsDisposed { get; protected set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Repository<T> GetRepository<T>() where T : Entity
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
