using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Data
{
    class ShoppingListItem
    {
        public int ID { get; set; }
        public int ShoppingListID { get; set; }
        public string contents { get; set; }
        public bool IsChecked { get; set; }
        public DateTimeOffset Created_Utc { get; set; }
        public DateTimeOffset Modified_Utc { get; set; }
    }
}
