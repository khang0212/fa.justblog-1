using FA.JustBlog.Data;
using FA.JustBlog.Models.Common;
using FA.JustBlog.Services;
using FA.JustBlog.WebMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FA.JustBlog.WebMVC.Areas.Admin.Controllers
{
    public class PostManagementController : Controller
    {
        private JustBlogDbContext db = new JustBlogDbContext();
        private readonly IPostServices _postServices;
        private readonly ICategoryServices _categoryServices;
        private readonly ITagServices _tagServices;

        public PostManagementController(IPostServices postServices, ICategoryServices categoryServices, ITagServices tagServices)
        {
            _postServices = postServices;
            _categoryServices = categoryServices;
            _tagServices = tagServices;
        }



        // GET: Admin/PostManagement
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString,
            int? pageIndex = 1, int pageSize = 2)
        {
            ViewData["CurrentPageSize"] = pageSize;
            ViewData["CurrentSort"] = sortOrder;
            ViewData["TitleSortParm"] = string.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            ViewData["UrlSlugSortParm"] = sortOrder == "UrlSlug" ? "urlSlug_desc" : "UrlSlug";
            ViewData["PublishedSortParm"] = sortOrder == "Published" ? "published_desc" : "Published";
            ViewData["PublishedDateSortParm"] = sortOrder == "PublishedDate" ? "publisheddate_desc" : "PublishedDate";
            ViewData["UpdatedAtSortParm"] = sortOrder == "UpdatedAt" ? "updatedAt_desc" : "UpdatedAt";

            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            // x => x.Name.Contains(searchString)
            Expression<Func<Post, bool>> filter = null;

            if (!string.IsNullOrEmpty(searchString))
            {
                filter = c => c.Title.Contains(searchString);
            }

            // q => q.OrderByDescending(c => c.Name)
            Func<IQueryable<Post>, IOrderedQueryable<Post>> orderBy = null;

            switch (sortOrder)
            {
                case "title_desc":
                    orderBy = q => q.OrderByDescending(c => c.Title);
                    break;
                case "UrlSlug":
                    orderBy = q => q.OrderBy(c => c.UrlSlug);
                    break;
                case "urlSlug_desc":
                    orderBy = q => q.OrderByDescending(c => c.UrlSlug);
                    break;
                case "Published":
                    orderBy = q => q.OrderBy(c => c.Published);
                    break;
                case "published_desc":
                    orderBy = q => q.OrderByDescending(c => c.Published);
                    break;
                case "PublishedDate":
                    orderBy = q => q.OrderBy(c => c.Published);
                    break;
                case "publisheddate_desc":
                    orderBy = q => q.OrderByDescending(c => c.Published);
                    break;
                case "UpdatedAt":
                    orderBy = q => q.OrderBy(c => c.UpdatedAt);
                    break;
                case "updatedAt_desc":
                    orderBy = q => q.OrderByDescending(c => c.UpdatedAt);
                    break;
                default:
                    orderBy = q => q.OrderBy(c => c.Title);
                    break;
            }

            var posts = await _postServices.GetAsync(filter: filter, orderBy: orderBy, pageIndex: pageIndex ?? 1, pageSize: pageSize);

            return View(posts);
        }

        

        // GET: Admin/PostManagement/Create
        public ActionResult Create()
        {
            //var postViewModel = new PostViewModel();
            //return View(postViewModel);
            ViewBag.CategoryId = new SelectList(_categoryServices.GetAll(), "Id", "Name");
            var postViewModel = new PostViewModel();
            postViewModel.Tags = (System.Collections.Generic.ICollection<Tag>)_tagServices.GetAll().Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Name});
            return View(postViewModel);
        }

        // POST: Admin/PostManagement/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PostViewModel postViewModel)
        {
            if (ModelState.IsValid)
            {
                var post = new Post
                {
                    Id = Guid.NewGuid(),
                    Title = postViewModel.Title,
                    ShortDescription = postViewModel.ShortDescription,
                    PostContent = postViewModel.PostContent,
                    UrlSlug = postViewModel.UrlSlug,
                    Published = postViewModel.Published,
                    CategoryId = postViewModel.CategoryId,
                    ImageUrl = postViewModel.ImageUrl,
                    Tags = await GetSelectedTagFromIds(postViewModel.SelectedTagIds)
                };
                //_postServices.Add(post);
                var result = await _postServices.AddAsync(post);
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(await _categoryServices.GetAllAsync(), "Id", "Name", postViewModel.CategoryId);
            postViewModel.Tags = (ICollection<Tag>)_tagServices.GetAll().Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Name });
            return View(postViewModel);
        }

        private async Task<ICollection<Tag>> GetSelectedTagFromIds(IEnumerable<Guid> selectedTagIds)
        {
            var tags = new List<Tag>();

            var tagEntities = await _tagServices.GetAllAsync();


            foreach (var item in tagEntities)
            {
                if (selectedTagIds.Any(x => x == item.Id))
                {
                    tags.Add(item);
                }
            }
            return tags;
        }

        // GET: Admin/PostManagement/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            ViewBag.CategoryId = new SelectList(_categoryServices.GetAll(), "Id", "Name");
            var post = await _postServices.GetByIdAsync((Guid)id);
            var postViewModel = new PostViewModel();
            postViewModel.Tags = (ICollection<Tag>)_tagServices.GetAll().Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Name });
            return View(post);
        }

        // POST: Admin/PostManagement/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public async Task<ActionResult> Edit(Post post)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(await _categoryServices.GetAllAsync(), "Id", "Name", post.CategoryId);
            return View(post);
        }


        // POST: Admin/PostManagement/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(Guid id)
        {
            Post post = _postServices.GetById(id);
            var result = false;
            if (post != null)
            {
                result = _categoryServices.Delete(post.Id);
            }

            if (result)
            {
                TempData["Message"] = "Delete Successful";
            }
            else
            {
                TempData["Message"] = "Delete Failed";
            }
            return RedirectToAction("Index");
        }

    }
}
