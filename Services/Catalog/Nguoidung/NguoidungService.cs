using Data.EF;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Catalog.Nguoidung
{
    public class NguoidungService : INguoidungService
    {
        private readonly tTSportDbContext _context;
        public NguoidungService(tTSportDbContext context)
        {
            this._context = context;
        }
        public async Task<List<NGUOIDUNG>> GetAll()
        {
            var query = from obj in _context.NGUOIDUNGs
                        select obj;
            return await query.ToListAsync();
        }
        public async Task<NGUOIDUNG> GetUser(string id)
        {
            return await _context.NGUOIDUNGs.FindAsync(id);
        }
        public async Task<int> CreateUser(NGUOIDUNG objNGUOIDUNG)
        {
            if (objNGUOIDUNG != null)
            {
                _context.NGUOIDUNGs.Add(objNGUOIDUNG);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
        public async Task<int> DeleteUser(string id)
        {
            if (string.IsNullOrEmpty(id))
                return 0;
            var objNGUOIDUNG = _context.NGUOIDUNGs.Find(id);
            if(objNGUOIDUNG != null)
            {
                _context.NGUOIDUNGs.Remove(objNGUOIDUNG);
                await _context.SaveChangesAsync();
                return 1;
            }
            return 0;
        }
        public async Task<int> UpdateUser(NGUOIDUNG objNGUOIDUNG)
        {
            if(objNGUOIDUNG != null)
            {
                var _nguoidung = _context.NGUOIDUNGs.Find(objNGUOIDUNG.ID);
                if(_nguoidung != null)
                {
                    _nguoidung.FIRSTNAME = objNGUOIDUNG.FIRSTNAME;
                    _nguoidung.LASTNAME = objNGUOIDUNG.LASTNAME;
                    _nguoidung.SEX = objNGUOIDUNG.SEX;
                    _nguoidung.DOB = objNGUOIDUNG.DOB;
                    _nguoidung.PHONE = objNGUOIDUNG.PHONE;
                    _nguoidung.EMAIL = objNGUOIDUNG.EMAIL;
                    _nguoidung.USERNAME = objNGUOIDUNG.USERNAME;
                    _nguoidung.PASSWORD = objNGUOIDUNG.PASSWORD;
                    _nguoidung.CREATE_BY = objNGUOIDUNG.CREATE_BY;
                    _nguoidung.CREATE_DAY = objNGUOIDUNG.CREATE_DAY;
                    _nguoidung.MODIFY = objNGUOIDUNG.MODIFY;
                    _nguoidung.LASTNAME = objNGUOIDUNG.LASTNAME;
                    await _context.SaveChangesAsync();
                    return 1;
                }
                return 0;
            }
            return 0;
        }
    }
}
