﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp.Models
{
    public class ShoppingListEdit
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least two characters.")]
        [MaxLength(128)]
        public string Name { get; set; }

        public string Color { get; set; }
    }
}
