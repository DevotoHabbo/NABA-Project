using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Data
{
    public interface IJwtAuthentication
    {
        string Authenticate(string username, string password);
    }
}
