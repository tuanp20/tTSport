using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Services.Catalog.Nguoidung;
using Services.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace API.Controllers
{
    [ApiController]
    //[Route("api/login")]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly INguoidungService _userRepository;
        private readonly ITokenService _tokenService;
        private string generatedToken = null;

        public LoginController(IConfiguration config, ITokenService tokenService, INguoidungService userRepository)
        {
            this._config = config;
            this._tokenService = tokenService;
            this._userRepository = userRepository;
        }
    }
}
