using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork_EFCore.Base;
using UnitOfWork_EFCore.Temp;

namespace UnitOfWork_EFCore
{
    public class ModelRepository: Repository<Model>, IModelRepository
    {
        internal ModelRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
