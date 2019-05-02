using Lena.Core.Enum;
using System;

namespace Lena.Core.Entity
{

    public class CoreEntity : IEntity<int>
    {
         public CoreEntity()
         {
            this.CreatedAt = DateTime.Now;
             this.CreatedBy = 1;
         }
         public int ID { get; set; }
         public DateTime? CreatedAt { get; set; }
         public int CreatedBy { get; set; }
    }
}
