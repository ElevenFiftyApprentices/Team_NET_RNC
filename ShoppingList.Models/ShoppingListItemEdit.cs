using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    class ShoppingListItemEdit
    {
        public int ShoppingListItemID { get; set; }
        public string Contents { get; set; }
        public bool IsChecked { get; set; }
        public Priority Priority { get; set; }
        public DateTimeOffset ModifiedUtc { get; set; }

    }
}
