using BlogAPI.Models.PostModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Data
{
    public interface IPostRepo
    {
        // Post
        IEnumerable<PostGetMany> GetPosts();
        IEnumerable<PostGetMany> GetPostsBySearch(string search);
        PostGetOne GetPost(int postId);
        bool PostExists(int postId);
        PostGetOne NewPost(NewPostRequest post);
        PostGetOne ChangePost(int postId,ChangePostRequest post);
        void DeletePost(int postId);

    }
}
