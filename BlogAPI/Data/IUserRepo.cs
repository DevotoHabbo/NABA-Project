using BlogAPI.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Data
{
    public interface IUserRepo
    {
        IEnumerable<UserGetMany> GetUsers();
        UserGetOne GetUser(string userId);
        UserGetOne NewUser(NewUserRequest user);
        UserGetOne ChangeUser(string userId, ChangeUserRequest user);
        void DeleteUser(string userId);
    }
}
