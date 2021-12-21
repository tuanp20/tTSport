using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Catalog.Nguoidung
{
    public interface INguoidungService
    {
        Task<List<NGUOIDUNG>> GetAll();
        Task<NGUOIDUNG> GetUser(string id);
        Task<int> CreateUser(NGUOIDUNG objNGUOIDUNG);
        Task<int> DeleteUser(string id);
        Task<int> UpdateUser(NGUOIDUNG objNGUOIDUNG);
    }
}
