using BlogAPI.Models.UserModels;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Data
{
    public class UserRepo : IUserRepo
    {
        private readonly string _connectionString;
        
        public UserRepo(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }
        public UserGetOne ChangeUser(string userId, ChangeUserRequest user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(string userId)
        {
            throw new NotImplementedException();
        }

        public UserGetOne GetUser(string userId)
        {
            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var user = connection.QueryFirstOrDefault<UserGetOne>(@"EXEC dbo.User_GetOne @UserId=@UserId", new { UserId = userId });
                return user;
            }
        }

        public IEnumerable<UserGetMany> GetUsers()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                return connection.Query<UserGetMany>(@"EXEC dbo.User_GetMany");
            }
        }

        public UserGetOne NewUser(NewUserRequest user)
        {
            throw new NotImplementedException();
        }
    }
}
