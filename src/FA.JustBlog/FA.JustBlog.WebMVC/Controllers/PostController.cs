﻿using FA.JustBlog.Models.Common;
using FA.JustBlog.Services;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
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
        // GET: Post
        public async Task<ActionResult> Index(int? pageIndex = 1, int? pageSize = 3)
        {
            Expression<Func<Post, bool>> filter = null;

            Func<IQueryable<Post>, IOrderedQueryable<Post>> orderBy = o => o.OrderBy(p => p.Title);
            var posts = await _postServices.GetAsync(filter: filter, orderBy: orderBy,
                pageIndex: pageIndex ?? 1, pageSize: pageSize ?? 3);
            return View(posts);
        }

        //public ActionResult LastestPosts()
        //{
        //    var popularTags = _postServices.GetLatestPostAsync(10);
        //    return PartialView("_ListPosts", popularTags);
        //}
        //public ActionResult MostViewedPosts()
        //{
        //    var highestView = _postServices.GetHighestViewCountPost(5);
        //    return PartialView("_ListPosts", highestView);
        //}

        public ActionResult LastestPosts()
        {
            var lastestPosts = Task.Run(() => _postServices.GetLatestPostAsync(5)).Result;
            ViewBag.PartialViewTitle = "Lastest Posts";
            return PartialView("_ListPosts", lastestPosts);
        }
        public ActionResult MostViewedPosts()
        {
            var lastestPosts = Task.Run(() => _postServices.GetHighestViewCountPost(5)).Result;
            ViewBag.PartialViewTitle = "Most Viewed Posts";
            return PartialView("_ListPosts", lastestPosts);
        }

        public async Task<ActionResult> Details(Guid id)
        {
            var post = await _postServices.GetByIdAsync(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }
    }
}