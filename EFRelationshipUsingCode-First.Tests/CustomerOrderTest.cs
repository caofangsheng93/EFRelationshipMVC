using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EF.Data;
using EF.Core.Data;
using System.Data.Entity;
using System.Collections.Generic;

namespace EFRelationshipUsingCode_First.Tests
{
    [TestClass]
    public class CustomerOrderTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Database.SetInitializer<EFDbContext>(new DropCreateDatabaseAlways<EFDbContext>());
            using (var context = new EFDbContext())
            {
                
                Customer customer = new Customer
                                    {
                                        CustomerName = "Raviendra",
                                        Email = "raviendra@test.com",
                                        AddedDate = DateTime.Now,
                                        ModifiedDate = DateTime.Now,
                                        IP = "1.1.1.1",
                                        Orders = new List<Order>{  
                                            new Order  
                                            {  
                                                Quanatity =12,  
                                                Price =15,  
                                                AddedDate = DateTime.Now,  
                                                ModifiedDate = DateTime.Now,  
                                                 IP = "1.1.1.1",  
                                            },  
                                            new Order  
                                            {  
                                                Quanatity =10,  
                                                Price =25,  
                                                AddedDate = DateTime.Now,  
                                                ModifiedDate = DateTime.Now,  
                                                 IP = "1.1.1.1",  
                                            }  
                                        }
                                    };
                context.Entry(customer).State = EntityState.Added;
                context.SaveChanges();
            }
        }
    }
}
