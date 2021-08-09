using FA.JustBlog.Services;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FA.JustBlog.WebMVC.Controllers
{
    public class TagController : Controller
    {
        private readonly ITagServices _tagServices;
        private readonly IPostServices _postServices;

        public TagController(ITagServices tagServices, IPostServices postServices)
        {
            _tagServices = tagServices;
            _postServices = postServices;
        }



        // GET: Tag
        public ActionResult Index()
        {
            return View();
        }
        //[ChildActionOnly]
        //public  ActionResult PopularTags()
        //{
        //    var popularTags = _tagServices.GetHighestViewCountTag(10);
        //    return PartialView("~/Views/Tag/_PopularTags.cshtml", popularTags);
        //}
        public async Task<ActionResult> Details(Guid id)
        {
            var tag = await _tagServices.GetByIdAsync(id);
            if (tag == null)
            {
                return HttpNotFound();
            }
            var post = await _postServices.GetPostsByTagAsync(tag.Id);
            ViewBag.TagName = tag.Name;
            return View(post);
        }

        public ActionResult PopularTags()
        {
            var popularTags = Task.Run(() => _tagServices.GetHighestViewCountTag(10)).Result;
            return PartialView("_PopularTags", popularTags);
        }
    }
}