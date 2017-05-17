using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Data
{
    class ShoppingList 
    {
        public int ID { get; set;}
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public DateTimeOffset Created_Utc { get; set; }
        public DateTimeOffset Modified_Utc { get; set; }
    }
}
