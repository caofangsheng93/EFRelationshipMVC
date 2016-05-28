using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF.Core.Data
{
   public class Order:BaseEntity
    {
       /// <summary>
       /// 数量
       /// </summary>
        public byte Quanatity { get; set; }
       /// <summary>
       /// 价格
       /// </summary>
        public decimal Price { get; set; }
       /// <summary>
       /// 客户编号
       /// </summary>
        public int CustomerId { get; set; }
       /// <summary>
        /// 导航属性Customer【带上Virtual是为了懒加载】
       /// </summary>
        public virtual Customer Customer { get; set; } 
    }
}
