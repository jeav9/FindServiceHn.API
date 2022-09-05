﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindServiceHn.Database.Models
{
    public class SubCategory
    {
        public int IdSubCategories { get; set; }
        public int IdCategory { get; set; }
        public string Description { get; set; }
        public int IdUserCreation { get; set; }
        public DateTime CreationDate { get; set; }
        public string Image { get; set; }
        
    }
}
