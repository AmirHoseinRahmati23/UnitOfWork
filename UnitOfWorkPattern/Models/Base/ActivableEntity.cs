using Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Base
{
    public abstract class ActivableEntity: ExtendedEntity, IActivable
    {
        public bool IsActive { get; set; }
    }
}
