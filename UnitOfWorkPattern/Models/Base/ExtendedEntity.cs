using Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Base
{
    public abstract class ExtendedEntity : Entity
    {
        /* Contains: 
         * 1-UpdateDateTime Property 
         * 2-......
         */
        public ExtendedEntity() : base()
        {
            
            UpdateTime = DateTime.Now;
        }

        [Display(ResourceType = typeof(DataDictionary)
            , Name = nameof(DataDictionary.UpdateDateTime))]
        public DateTime UpdateTime { get; set; }
    }
}
