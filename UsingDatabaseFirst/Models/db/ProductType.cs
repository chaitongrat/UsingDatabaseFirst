using System;
using System.Collections.Generic;

namespace UsingDatabaseFirst.Models.db
{
    public partial class ProductType
    {
        public ProductType()
        {
            Products = new HashSet<Product>();
        }

        public string ProductTypeId { get; set; } = null!;
        public string? ProductTypeName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
