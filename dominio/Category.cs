﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryDescription { get; set; }

        public override string ToString()
        {
            return CategoryDescription;
        }
    }
}
