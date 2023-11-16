using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Repositories;
using UnitOfWork.Services;
using UnitOfWork.Tools;

namespace UnitOfWork
{
    public class UnitOfWork : Base.UnitOfWork, IUnitOfWork
    {
        public UnitOfWork(Options options) : base(options)
        {}

		private IModelRepository? _modelRepository;

		public IModelRepository ModelRepository
		{
			get
			{
				if (_modelRepository == null)
				{
					_modelRepository =
						new ModelRepository(DatabaseContext);
				}

				return _modelRepository;
			}
		}
	}



	/* 
	 * private IXXXXXRepository _xXXXXRepository;
		
	   public IXXXXXRepository XXXXXRepository
	   {
			get
			{
				if (_xXXXXRepository == null)
				{
					_xXXXXRepository =
						new XXXXXRepository(DatabaseContext);
				}

				return _xXXXXRepository;
			}
	   }
	 **************************************************
	 */
}
