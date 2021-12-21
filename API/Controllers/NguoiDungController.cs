using Microsoft.AspNetCore.Mvc;
using Services.Catalog.Nguoidung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NguoiDungController : ControllerBase
    {
        private readonly INguoidungService _nguoiDungService;
        public NguoiDungController(INguoidungService nguoiDungService)
        {
            this._nguoiDungService = nguoiDungService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var lstNguoiDung = await _nguoiDungService.GetAll();
            return Ok(lstNguoiDung);
        }
    }
}
