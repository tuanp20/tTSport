using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Catalog.DmBaiViet
{
    public interface IDmBaiVietService
    {
        Task<int> Create(DMBAIVIET _baiViet);
        Task<int> Update(DMBAIVIET _baiViet);
        Task<int> Delete(string id);
        Task<List<DMBAIVIET>> GetAll();
        Task<DMBAIVIET> GetById(string id);
    }
}
