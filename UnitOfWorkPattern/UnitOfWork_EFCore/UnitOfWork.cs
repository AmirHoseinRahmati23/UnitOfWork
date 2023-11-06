using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork_EFCore.Repositories;
using UnitOfWork_EFCore.Services;
using UnitOfWork_EFCore.Tools;

namespace UnitOfWork_EFCore
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
