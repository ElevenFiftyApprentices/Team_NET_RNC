using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ShoppingList.Models
{
    class NoteDetail
    {
        [Key]
        public int NoteID { get; set; }
        public int ShoppingListItemID { get; set; }
        public string Body { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
