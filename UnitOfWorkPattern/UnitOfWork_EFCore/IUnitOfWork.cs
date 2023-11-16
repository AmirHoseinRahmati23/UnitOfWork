using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Repositories;

namespace UnitOfWork
{
    public interface IUnitOfWork : Base.IUnitOfWork
    {
        IModelRepository ModelRepository { get; }
    }
}
