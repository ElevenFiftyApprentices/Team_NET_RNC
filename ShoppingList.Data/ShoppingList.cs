using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ShoppingList.Data
{
    class ShoppingList 
    {
        [Key]
        public int ShoppingListID { get; set;}
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public DateTimeOffset Created_Utc { get; set; }
        public DateTimeOffset Modified_Utc { get; set; }
    }
}
