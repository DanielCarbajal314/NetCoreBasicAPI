using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Entities.Generics
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; internal set; }

        public BaseEntity()
        {
            this.CreatedDate = DateTime.Now;
        }
    }
}
