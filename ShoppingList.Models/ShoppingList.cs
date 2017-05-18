using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    class ShoppingList
    {
        public int ShoppingListID { get; set; }

        public int UserID { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public override string ToString() => $"[{ShoppingListID}] {Name}";

    }
}
