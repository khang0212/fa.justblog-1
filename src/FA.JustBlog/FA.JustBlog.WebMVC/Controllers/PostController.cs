using FA.JustBlog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FA.JustBlog.WebMVC.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        private readonly IPostServices _postServices;
        private readonly ICategoryServices _categoryServices;

        public PostController(IPostServices postServices, ICategoryServices categoryServices)
        {
            _postServices = postServices;
            _categoryServices = categoryServices;
        }
        // GET: Posts
        public async Task<ActionResult> Index()
        {
            var lastestPost = await _postServices.GetLatestPostAsync(5);
            return View(lastestPost);
        }

        public async Task<ActionResult> LastestPosts()
        {
            var lastestPost = await _postServices.GetLatestPostAsync(5);
            return PartialView(lastestPost);
        }
    }
}