﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Entities;

namespace WebApplication2.Data
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
            
        }
    }
}
