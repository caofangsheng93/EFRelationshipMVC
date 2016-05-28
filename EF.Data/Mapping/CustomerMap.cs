using EF.Core.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EF.Data.Mapping
{
   public class CustomerMap:EntityTypeConfiguration<Customer>
    {
       public CustomerMap()
       {
           //配置主键
           this.HasKey(t => t.ID);

           //配置字段
           this.Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
           Property(t => t.CustomerName);
           Property(t => t.Email).IsRequired();
           Property(t => t.AddedDate).IsRequired();
           Property(t => t.ModifiedDate).IsRequired();
           Property(t => t.IP);

           //table  
           ToTable("Customers");  
       }
    }
}
