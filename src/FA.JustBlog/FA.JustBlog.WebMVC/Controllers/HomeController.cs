using FA.JustBlog.Services;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FA.JustBlog.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostServices _postServices;
        private readonly ITagServices _tagServices;

        public HomeController(IPostServices postServices, ITagServices tagServices)
        {
            _postServices = postServices;
            _tagServices = tagServices;
        }

        public async Task<ActionResult> Index()
        {
            var posts = await _postServices.GetAllAsync();
            return View(posts);
        }
        public async Task<ActionResult> PostDetails(Guid id)
        {
            var posts = await _postServices.GetByIdAsync(id);
            return View(posts);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [ChildActionOnly]
        public ActionResult AboutCard()
        {
            return PartialView("_PartialAboutCard");
        }
    }
}