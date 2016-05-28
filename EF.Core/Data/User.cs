using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Core.Data
{
   public class User:BaseEntity
    {
       /// <summary>
       /// 用户名
       /// </summary>
       public string UserName { get; set; }

       /// <summary>
       /// 电子邮件
       /// </summary>
       public string Email { get; set; }

       /// <summary>
       /// 密码
       /// </summary>
       public string Password { get; set; }

       /// <summary>
       /// 导航属性--UserProfile【user-UserProfile一对一】
       /// 注意：这里没有加Virtual关键字，UserProfile实体中，User导航属性加了
       /// </summary>
       public UserProfile UserProfile { get; set; }
    }
}
