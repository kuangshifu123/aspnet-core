using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace SnkrsMonitor.Product
{
    public class Product:Entity<Guid>
    {
        public string No { get; set; }//货号1
        public string Name { get; set; }//名称
        public string Code { get; set; }//货号2
        public string Price { get; set; }//发售价
        public string IndexPicUrl { get; set; }//图片连接
    }
}
