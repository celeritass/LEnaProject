using Lena.Core.Map;
using LenaProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.Model.Maps
{
    public class UserMap : CoreMap<User>
    {
        public UserMap()
        {
            ToTable("dbo.Users");            
            Property(m => m.UserName).HasMaxLength(15).IsRequired();
            Property(m => m.Password).HasMaxLength(10).IsRequired();// password şartlarını nereye nasıl yazcaz?
        }
    }
}
