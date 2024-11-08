﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Entities;

namespace Data.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetAllWithDetailsAsync();

        Task<Product> GetByIdWithDetailsAsync(int id);
    }
}
