using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace UdemyNlayerProject.Core.Models
{
 public  class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StockCode { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public bool IsDeleted { get; set; }
        public string InnerBarcode { get; set; }
        public virtual Category Category { get; set; }
    }
}
