using Data.EF;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Catalog.DmLoaiBaiViet
{
    public class LoaiBaiVietService : ILoaiBaiVietService
    {
        private readonly tTSportDbContext _context;
        public LoaiBaiVietService(tTSportDbContext context)
        {
            this._context = context;
        }
        public async Task<int> Create(DMLOAIBAIVIET _loaiBaiViet)
        {
            if (_loaiBaiViet != null)
            {
                _context.DMLOAIBAIVIETs.Add(_loaiBaiViet);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
        public async Task<int> Update(DMLOAIBAIVIET _loaiBaiViet)
        {
            if (_loaiBaiViet != null)
            {
                var objLOAIBAIVIET = _context.DMLOAIBAIVIETs.Find(_loaiBaiViet.ID);
                if (objLOAIBAIVIET != null)
                {
                    objLOAIBAIVIET.TENLOAI = _loaiBaiViet.TENLOAI;
                    objLOAIBAIVIET.MOTA = _loaiBaiViet.MOTA;
                    objLOAIBAIVIET.CREATE_BY = _loaiBaiViet.CREATE_BY;
                    objLOAIBAIVIET.CREATE_DAY = _loaiBaiViet.CREATE_DAY;
                    objLOAIBAIVIET.MODIFY = _loaiBaiViet.MODIFY;
                    objLOAIBAIVIET.LASTUPDATE = _loaiBaiViet.LASTUPDATE;
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
            var _loaiBaiViet = _context.DMLOAIBAIVIETs.Find(id);
            if (_loaiBaiViet != null)
            {
                _context.DMLOAIBAIVIETs.Remove(_loaiBaiViet);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
        public async Task<List<DMLOAIBAIVIET>> GetAll()
        {
            return await _context.DMLOAIBAIVIETs.ToListAsync();
        }
        public async Task<DMLOAIBAIVIET> GetById(string id)
        {
            //if (!string.IsNullOrEmpty(id))
            return await _context.DMLOAIBAIVIETs.FindAsync(id);
            //return false;
        }
    }
}
