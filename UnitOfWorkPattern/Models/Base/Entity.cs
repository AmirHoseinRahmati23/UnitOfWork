using Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Base
{
    public abstract class Entity : object
    {
        public Entity() : base()
        {
            Id = Guid.NewGuid();
            IsDeleted = false;
        }

        [Key]
        [Display(ResourceType = typeof(DataDictionary),
            Name = nameof(DataDictionary.Id))]
        public Guid Id { get; set; }


        public bool IsDeleted { get; set; }


    }
}
