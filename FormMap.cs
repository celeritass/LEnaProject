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
    public class FormMap : CoreMap<Form>
    {
        public FormMap()
        {
            ToTable("dbo.Forms"); // table adını çoğul yapma diye yırtınmadık mı:( bizim örneklerde öyle yapmışız            
            Property(m => m.Name).HasMaxLength(15).IsRequired();
            Property(m => m.Description).HasColumnType("ntext").IsRequired();
        }
    }
}
