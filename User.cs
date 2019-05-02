using Lena.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.Model.Entities
{
    public class User : CoreEntity
    {
        
        public string UserName { get; set; }// daha fazlasını özellikle eklemedim, istenilenin dışına çıkmamak için
        public string Password { get; set; }

        //bir kullanıcı birden fazla formu doldurabilir (görüntüleyebilir, falan) ancak 1 form 1 kullanıcı tarafından doldurulur (ve görüntülenir?)
        public virtual List<Form> Forms { get; set; }
    }
}
