using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF.Core.Data
{
   public class UserProfile:BaseEntity
    {
       /// <summary>
       /// 姓氏
       /// </summary>
       public string FirstName { get; set; }

       /// <summary>
       /// 名字
       /// </summary>
       public string LastName { get; set; }

       /// <summary>
       /// 地址
       /// </summary>
       public string Address { get; set; }

       /// <summary>
       /// 导航属性-User
       /// </summary>
       public virtual User User { get; set; }
    }
}
