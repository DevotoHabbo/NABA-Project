using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAPI.Atributes;
using BlogAPI.Data;
using BlogAPI.Models;
using BlogAPI.Models.PostModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostRepo _postRepo;
        public PostsController(IPostRepo postRepo)
        {
            _postRepo =  postRepo;
        }
        // GET: api/<PostsController>
        [HttpGet]
        public IEnumerable<PostGetMany> GetPosts(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                return _postRepo.GetPosts();
            }
            else
            {
                return _postRepo.GetPostsBySearch(search);
            }
        }
        // GET api/<PostsController>/5
        [HttpGet("{postId}")]
        public ActionResult<PostGetOne> GetPost(int postId)
        {
            var post = _postRepo.GetPost(postId);
            if(post == null)
            {
                return NotFound();
            }
            return post;
        }

        // POST api/<PostsController>
        [HttpPost]
        public ActionResult<PostGetOne> NewPost(NewPostRequest newPostRequest)
        {
            var savedPost = _postRepo.NewPost(newPostRequest);
            return CreatedAtAction(nameof(GetPost), new { postId = savedPost.PostId }, savedPost);

        }
        // PUT api/<PostsController>/5
        [HttpPatch("{postId}")]
        public ActionResult<PostGetOne> ChangePost(int postId, ChangePostRequest changePostRequest)
        {
            var post = _postRepo.GetPost(postId);
            if (post == null)
            {
                return NotFound();
            }
            changePostRequest.Title = string.IsNullOrEmpty(changePostRequest.Title) ? post.Title : changePostRequest.Title;
            changePostRequest.Content = string.IsNullOrEmpty(changePostRequest.Content) ? post.Content : changePostRequest.Content;
            var savedPost = _postRepo.ChangePost(postId, changePostRequest);
            return savedPost;

        }

        // DELETE api/<PostsController>/5
        [HttpDelete("{postId}")]
        public ActionResult DeletePost(int postId)
        {
            var post = _postRepo.GetPost(postId);
            if (post == null)
            {
                return NotFound();
            }
            _postRepo.DeletePost(postId);
            return NoContent();
        }
    }
}
