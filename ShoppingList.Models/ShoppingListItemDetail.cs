using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    class ShoppingListItemDetail
    {
        public int ShoppingListItemID { get; set; }
        public int ShoppingListID { get; set; }
        public string contents { get; set; }
        public bool IsChecked { get; set; }
        public Priority Priority { get; set; }
        public DateTimeOffset Created_Utc { get; set; }
        public DateTimeOffset ModifiedUtc { get; set; }
    }
}
