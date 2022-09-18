using System;
using System.Collections.Generic;

namespace UsingDatabaseFirst.Models.db
{
    public partial class Unit
    {
        public Unit()
        {
            Products = new HashSet<Product>();
        }

        public string UnitId { get; set; } = null!;
        public string? UnitName { get; set; }
        public int? QuantityPerUnit { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
