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

    }
}
