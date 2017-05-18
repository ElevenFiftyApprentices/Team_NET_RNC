using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Models
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

    class ShoppingListItemCreate
    {
        public int ShoppingListItemID { get; set; }

        public int ShoppingListID { get; set; }

        public string contents { get; set; }

        public bool IsChecked { get; set; }

        public Priority Priority { get; set; }
        public DateTimeOffset Created_Utc { get; set; }
    }
}
