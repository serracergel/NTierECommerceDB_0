﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class OrderDetailMap : BaseMap<OrderDetail>
    {
        public OrderDetailMap()
        {
            Property(x => x.Discount).HasColumnType("money");
            //İlişki Ayarlamaları
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.OrderID,
                x.ProductID
            });
        }
    }
}
