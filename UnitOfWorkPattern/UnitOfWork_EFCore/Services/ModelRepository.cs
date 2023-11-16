using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Base;
using UnitOfWork.Repositories;
using UnitOfWork.Temp;

namespace UnitOfWork.Services
{
    public class ModelRepository : Repository<Model>, IModelRepository
    {
        internal ModelRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
