using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Catalog.DmLoaiBaiViet
{
    public interface ILoaiBaiVietService
    {
        Task<int> Create(DMLOAIBAIVIET _loaiBaiViet);
        Task<int> Update(DMLOAIBAIVIET _loaiBaiViet);
        Task<int> Delete(string id);
        Task<List<DMLOAIBAIVIET>> GetAll();
        Task<DMLOAIBAIVIET> GetById(string id);
    }
}
