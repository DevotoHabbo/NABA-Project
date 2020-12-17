using BlogAPI.Models.PostModels;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Data
{
    public class PostRepo : IPostRepo
    {
        private readonly string _connectionString;
        public PostRepo(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        // Post Repo
        public PostGetOne GetPost(int postId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var post = connection.QueryFirstOrDefault<PostGetOne>(@"EXEC dbo.Post_GetById @PostId=@PostId", new { PostId = postId });
                return post;
            }
        }
        public IEnumerable<PostGetMany> GetPosts()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                return connection.Query<PostGetMany>(@"EXEC dbo.Posts_Get");
            }
        }

        public IEnumerable<PostGetMany> GetPostsBySearch(string search)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                return connection.Query<PostGetMany>(@"EXEC dbo.Posts_GetBySearch @Search = @Search", new { Search = search });
            }
        }

        public bool PostExists(int postId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                return connection.QueryFirst<bool>(@"EXEC dbo.Post_Exists @PostId=@PostId", new { PostId = postId });
            }
        }
        public PostGetOne NewPost(NewPostRequest post)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var postId = connection.QueryFirst<int>(@"EXEC dbo.Post_Insert @Title=@Title,@Content=@Content,@UserId=@UserId", post);
                return GetPost(postId);
            }
        }

        public PostGetOne ChangePost(int postId, ChangePostRequest post)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute(@"EXEC dbo.Post_Update @PostId=@PostId,@Title=@Title,@Content=@Content", new { PostId = postId, post.Title, post.Content });
                return GetPost(postId);
            }
        }

        public void DeletePost(int postId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute(@"EXEC dbo.Post_Delete @PostId=@PostId", new { PostId = postId });
            }
        }
    }
}
