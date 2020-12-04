﻿using BlogAPI.MVC.Models;
using BlogAPI.MVC.Models.CommentModels;
using BlogAPI.MVC.Models.PostModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.MVC.Data
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

        // Comment
        CommentGet GetComment(int commentId);
        CommentGet NewComment(NewCommentRequest comment);
    }
}