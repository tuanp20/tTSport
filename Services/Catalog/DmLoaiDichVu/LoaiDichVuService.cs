using Data.EF;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Catalog.DmLoaiDichVu
{
    public class LoaiDichVuService : ILoaiDichVuService
    {
        private readonly tTSportDbContext _context;
        public LoaiDichVuService(tTSportDbContext context)
        {
            this._context = context;
        }
        public async Task<int> Create(DMLOAIDICHVU _loaiDichVu)
        {
            if (_loaiDichVu != null)
            {
                _context.DMLOAIDICHVUs.Add(_loaiDichVu);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
        public async Task<int> Update(DMLOAIDICHVU _loaiDichVu)
        {
            if (_loaiDichVu != null)
            {
                var objBAIVIET = _context.DMLOAIDICHVUs.Find(_loaiDichVu.ID);
                if (objBAIVIET != null)
                {
                    objBAIVIET.TENDICHVU = _loaiDichVu.TENDICHVU;
                    objBAIVIET.CREATE_BY = _loaiDichVu.CREATE_BY;
                    objBAIVIET.CREATE_DAY = _loaiDichVu.CREATE_DAY;
                    objBAIVIET.MODIFY = _loaiDichVu.MODIFY;
                    objBAIVIET.LASTUPDATE = _loaiDichVu.LASTUPDATE;
                    await _context.SaveChangesAsync();
                    return 1;
                }
                return 0;
            }
            return 0;
        }
        public async Task<int> Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
                return 0;
            var _loaiDichVu = _context.DMLOAIDICHVUs.Find(id);
            if (_loaiDichVu != null)
            {
                _context.DMLOAIDICHVUs.Remove(_loaiDichVu);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
        public async Task<List<DMLOAIDICHVU>> GetAll()
        {
            return await _context.DMLOAIDICHVUs.ToListAsync();
        }
        public async Task<DMLOAIDICHVU> GetById(string id)
        {
            //if (!string.IsNullOrEmpty(id))
            return await _context.DMLOAIDICHVUs.FindAsync(id);
            //return false;
        }
    }
}
