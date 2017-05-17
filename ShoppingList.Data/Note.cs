using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Data
{
    class Note
    {
        public int ID { get; set; }
        public int ShoppingListItemID { get; set; }
        public string body { get; set; }
        public DateTimeOffset Created_Utc { get; set; }
        public DateTimeOffset? Modified_Utc { get; set; }
    }
}
