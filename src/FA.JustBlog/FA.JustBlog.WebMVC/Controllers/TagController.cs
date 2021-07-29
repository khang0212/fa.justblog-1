using FA.JustBlog.Services;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FA.JustBlog.WebMVC.Controllers
{
    public class TagController : Controller
    {
        private readonly ITagServices _tagServices;

        public TagController(ITagServices tagServices)
        {
            _tagServices = tagServices;
        }

        // GET: Tag
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public async Task<ActionResult> PopularTags()
        {
            var popularTags = await _tagServices.GetHighestViewCountTagAsync(10);
            return PartialView("~/Views/Tag/_PopularTags.cshtml", popularTags);
        }
    }
}