using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using EF.Core.Data;
using System.Collections.Generic;
using EF.Data;

namespace EFRelationshipUsingCode_First.Tests
{
    [TestClass]
    public class StudentCourseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Database.SetInitializer<EFDbContext>(new CreateDatabaseIfNotExists<EFDbContext>());
            using (var context = new EFDbContext())
            {
                context.Database.Create();
                Student student = new Student
                {
                    Name = "Sandeep",
                    Age = 25,
                    IsCurrent = true,
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IP = "1.1.1.1",
                    Courses = new List<Course>{  
                        new Course  
                        {  
                            Name = "Asp.Net",  
                            MaximumStrength = 12,  
                            AddedDate = DateTime.Now,  
                            ModifiedDate = DateTime.Now,  
                            IP = "1.1.1.1"  
                        },  
                         new Course  
                        {  
                            Name = "SignalR",  
                            MaximumStrength = 12,  
                            AddedDate = DateTime.Now,  
                            ModifiedDate = DateTime.Now,  
                            IP = "1.1.1.1"  
                        }  
                    }
                };
                Course course = new Course
                {
                    Name = "Web API",
                    MaximumStrength = 12,
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IP = "1.1.1.1",
                    Students = new List<Student>{  
                        new Student  
                        {  
                            Name = "Raviendra",  
                            Age = 25,  
                            IsCurrent = true,  
                            AddedDate = DateTime.Now,  
                            ModifiedDate = DateTime.Now,  
                            IP = "1.1.1.1",  
                        },  
                         new Student  
                        {  
                          Name = "Pradeep",  
                        Age = 25,  
                        IsCurrent = true,  
                        AddedDate = DateTime.Now,  
                        ModifiedDate = DateTime.Now,  
                        IP = "1.1.1.1",  
                        }  
                    }
                };
                context.Entry(student).State = EntityState.Added;
                context.Entry(course).State = EntityState.Added;
                context.SaveChanges();
            }  
        }
    }
}
