using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Login
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer, NGUOIDUNG user);
        bool ValidateToken(string key, string issuer, string token);
    }
}
