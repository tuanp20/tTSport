using Data.EF;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Catalog.DmBaiViet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace API.Controllers.Admin
{

    //[Route("api/[controller]")]
    [ApiController]
    public class DmBaiVietController : ControllerBase
    {
        private readonly IDmBaiVietService _dmBaiVietService;
        public DmBaiVietController(IDmBaiVietService dmBaiVietService)
        {
            this._dmBaiVietService = dmBaiVietService;
        }
        //[HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(DMBAIVIET _baiViet)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _dmBaiVietService.Create(_baiViet);
            if (result == 0)
                return BadRequest();
            return Ok();
        }
    }
}
