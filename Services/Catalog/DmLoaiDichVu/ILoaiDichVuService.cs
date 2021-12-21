using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Catalog.DmLoaiDichVu
{
    public interface ILoaiDichVuService
    {
        Task<int> Create(DMLOAIDICHVU _loaiDichVu);
        Task<int> Update(DMLOAIDICHVU _loaiDichVu);
        Task<int> Delete(string id);
        Task<List<DMLOAIDICHVU>> GetAll();
        Task<DMLOAIDICHVU> GetById(string id);
    }
}
