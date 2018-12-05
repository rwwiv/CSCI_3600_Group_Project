using System.IO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CSCI_3600_Group_Project.Controllers
{
    public class FilesController : Controller
    {
        // GET
        public JsonResult Index()
        {
            var userName = User.FindFirst("email");
            var directoryInfo = new DirectoryInfo($"./files/{userName}/");
            var files = directoryInfo.GetFiles("");
            return Json(files);
        }
    }
}