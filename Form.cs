using Lena.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.Model.Entities
{
    public class Form : CoreEntity
    {       
        
        public string Name { get; set; }
        public string Description { get; set; }
        
        //created by , createdat sabit ve daha önce tanımlandığı için buralara yazmadım.id de aynı sebepten tabii ki
        //bir kullanıcı birden fazla formu doldurabilir (görüntüleyebilir, falan) ancak 1 form 1 kullanıcı tarafından doldurulur (ve görüntülenir?)
        public virtual User User { get; set; }
    }
}
