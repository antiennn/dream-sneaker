﻿using System;
using System.Collections.Generic;

#nullable disable

namespace QLBG.DAL.Models
{
    public partial class Category
    {
        public Category()
        {
            Shoes = new HashSet<Shoe>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Shoe> Shoes { get; set; }
    }
}
