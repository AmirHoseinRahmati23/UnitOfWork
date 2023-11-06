using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork_EFCore.Repositories;

namespace UnitOfWork_EFCore
{
    public interface IUnitOfWork : Base.IUnitOfWork
    {
        IModelRepository ModelRepository { get; }
    }
}
