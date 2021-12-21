using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Catalog.DmKhachHang
{
    public interface IKhachHangService
    {
        Task<int> Create(DMKHACHHANG _baiViet);
        Task<int> Update(DMKHACHHANG _baiViet);
        Task<int> Delete(string id);
        Task<List<DMKHACHHANG>> GetAll();
        Task<DMKHACHHANG> GetById(string id);
    }
}
