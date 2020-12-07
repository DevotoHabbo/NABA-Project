using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Data
{
    public class JwtAuthentication : IJwtAuthentication
    {
        private readonly IDictionary<string, string> users = new Dictionary<string, string> { { "test1", "password1" }, { "test2", "password1" } };

        public string Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
