using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCore.Services.AuthService.Interfaces
{
    public interface IJwtFactoryService
    {
        Task<String> GenerateToken(string userName, string id, IList<string> roles);
    }
}
