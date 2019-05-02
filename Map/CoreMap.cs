using Lena.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lena.Core.Map
{
    public class CoreMap<T>:EntityTypeConfiguration<T> where T : CoreEntity
    {
        public CoreMap()
        {
            Property(m => m.ID).HasColumnName("ID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(m => m.CreatedAt).IsRequired(); // sanırım bunları yazmamam gerekiyordu çnk sadeece form için istemiş
            Property(m => m.CreatedBy).IsRequired();
        }
    }
}
