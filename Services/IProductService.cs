﻿using Entities;

namespace Services
{
    public interface IProductService
    {
  
        Task<List<Product>> Get();

    }
}