﻿using EF.Core.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Mapping
{
   public class StudentMap:EntityTypeConfiguration<Student>
    {
       public StudentMap()
       {
           //配置主键
           this.HasKey(t => t.ID);
           //property  
           Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
           Property(t => t.Name);
           Property(t => t.Age);
           Property(t => t.IsCurrent);
           Property(t => t.AddedDate).IsRequired();
           Property(t => t.ModifiedDate).IsRequired();
           Property(t => t.IP);

           //table  
           ToTable("Students");

           //relationship  
           this.HasMany(s => s.Courses)
               .WithMany(s => s.Students)
               .Map(s => s.ToTable("StudentCourse")
                   .MapLeftKey("StudentId")
                   .MapRightKey("CourseId")    //这里如果不手动映射的键值的话，就会按照Class名_ID来生成主键
                   );

       }
    }
}
