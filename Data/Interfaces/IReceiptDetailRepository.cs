﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Entities;

namespace Data.Interfaces
{
    public interface IReceiptDetailRepository : IRepository<ReceiptDetail>
    {
        Task<IEnumerable<ReceiptDetail>> GetAllWithDetailsAsync();
    }
}
