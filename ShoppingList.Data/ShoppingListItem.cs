using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Data
{

    enum Priority
    {
        [Description("grab it now!")]
        High,
        [Description("Need it soon.")]
        Medium,
        [Description("It can wait.")]
        Low
    }

    class ShoppingListItem
    {
        public int ID { get; set; }
        public int ShoppingListID { get; set; }
        public string contents { get; set; }
        public bool IsChecked { get; set; }
        public Priority Priority { get; set;  }
        public DateTimeOffset Created_Utc { get; set; }
        public DateTimeOffset Modified_Utc { get; set; }
    }
}
