using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Core.Data
{
   public class Customer:BaseEntity
    {
       /// <summary>
       /// 客户名称
       /// </summary>
       public string CustomerName { get; set; }

       /// <summary>
       /// 电子邮件
       /// </summary>
       public string Email { get; set; }

       /// <summary>
       /// 导航属性--Orders [带了Virtual，是为懒加载]
       /// </summary>
       public virtual ICollection<Order> Orders { get; set; }


    }
}
