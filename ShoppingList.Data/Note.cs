using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ShoppingList.Data
{
    class Note
    {
        [Key]
        public int NoteID { get; set; }
        public int ShoppingListItemID { get; set; }
        public string body { get; set; }
        public DateTimeOffset Created_Utc { get; set; }
        public DateTimeOffset? Modified_Utc { get; set; }
    }
}
