using Data.EF;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Catalog.DmKhachHang
{
    public class KhachHangService : IKhachHangService
    {
        private readonly tTSportDbContext _context;
        public KhachHangService(tTSportDbContext context)
        {
            this._context = context;
        }
        public async Task<int> Create(DMKHACHHANG _khachHang)
        {
            if (_khachHang != null)
            {
                _context.DMKHACHHANGs.Add(_khachHang);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
        public async Task<int> Update(DMKHACHHANG _khachHang)
        {
            if (_khachHang != null)
            {
                var objKHACHHANG = _context.DMKHACHHANGs.Find(_khachHang.ID);
                if (objKHACHHANG != null)
                {
                    objKHACHHANG.TENKHACH = _khachHang.TENKHACH;
                    objKHACHHANG.CREATE_BY = _khachHang.CREATE_BY;
                    objKHACHHANG.CREATE_DAY = _khachHang.CREATE_DAY;
                    objKHACHHANG.MODIFY = _khachHang.MODIFY;
                    objKHACHHANG.LASTUPDATE = _khachHang.LASTUPDATE;
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
            var _khachHang = _context.DMKHACHHANGs.Find(id);
            if (_khachHang != null)
            {
                _context.DMKHACHHANGs.Remove(_khachHang);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
        public async Task<List<DMKHACHHANG>> GetAll()
        {
            return await _context.DMKHACHHANGs.ToListAsync();
        }
        public async Task<DMKHACHHANG> GetById(string id)
        {
            //if (!string.IsNullOrEmpty(id))
            return await _context.DMKHACHHANGs.FindAsync(id);
            //return false;
        }
    }
}
