using Data.EF;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Catalog.DmBaiViet
{
    public class DmBaiVietService :IDmBaiVietService
    {
        private readonly tTSportDbContext _context;
        public DmBaiVietService(tTSportDbContext context)
        {
            this._context = context;
        }
        public async Task<int> Create(DMBAIVIET _baiViet)
        {
            if(_baiViet != null)
            {
                _context.DMBAIVIETs.Add(_baiViet);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
        public async Task<int> Update (DMBAIVIET _baiViet)
        {
            if(_baiViet != null)
            {
                var objBAIVIET = _context.DMBAIVIETs.Find(_baiViet.ID);
                if(objBAIVIET != null)
                {
                    objBAIVIET.TENBAI = _baiViet.TENBAI;
                    objBAIVIET.MOTA = _baiViet.MOTA;
                    objBAIVIET.CREATE_BY = _baiViet.CREATE_BY;
                    objBAIVIET.CREATE_DAY = _baiViet.CREATE_DAY;
                    objBAIVIET.MODIFY = _baiViet.MODIFY;
                    objBAIVIET.LASTUPDATE = _baiViet.LASTUPDATE;
                    await _context.SaveChangesAsync();
                    return 1;
                }
                return 0;
            }
            return 0;
        }
        public async Task<int> Delete (string id)
        {
            if (string.IsNullOrEmpty(id))
                return 0;
            var _baiViet = _context.DMBAIVIETs.Find(id);
            if(_baiViet != null)
            {
                _context.DMBAIVIETs.Remove(_baiViet);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
        public async Task<List<DMBAIVIET>> GetAll()
        {
            return await _context.DMBAIVIETs.ToListAsync();
        }
        public async Task<DMBAIVIET> GetById(string id)
        {
            //if (!string.IsNullOrEmpty(id))
                return await _context.DMBAIVIETs.FindAsync(id);
            //return false;
        }
    }
}
