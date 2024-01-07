using CM.PlayBall.GroupManagement.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CM.PlayBall.GroupManagement.Web.Controllers
{
    public class GroupsController : Controller
    {
        private static List<GroupViewModel> groups;

        public GroupsController()
        {
            groups = new List<GroupViewModel>() {new GroupViewModel { Id = 1, Name = "Christian"} };
        }

        public IActionResult Index()
        {
            return View(groups);
        }
    }
}
