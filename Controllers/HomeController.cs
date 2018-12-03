using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.StaticFiles;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using CSCI_3600_Group_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace CSCI_3600_Group_Project.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult UserHome()
        {            
            var userName = this.User.Identity.Name;
            var directoryInfo = new DirectoryInfo($"./files/{userName}/");
            var files = directoryInfo.GetFiles("");
            var outputFileList = new List<FileModel>();
            var i = 0;
            foreach (var file in files)
            {
                outputFileList.Add(new FileModel());
                outputFileList[i].Name = file.Name;
                outputFileList[i].Size = file.Length;
                outputFileList[i].FileType = file.Extension;
                outputFileList[i].FontAwesomeFileType = file.Extension;
                outputFileList[i].LastModified = file.LastWriteTimeUtc;
                outputFileList[i].Owner = User.Identity.Name;
                i++;
            }
            return View(outputFileList);
        }
        
        [HttpGet]
        [Route("Home/download")]
        public ActionResult DownloadFile(string fileDir)
        {
            string filename = Path.Combine(Directory.GetCurrentDirectory(),
                                    "files", fileDir);
            string filepath = AppDomain.CurrentDomain.BaseDirectory + filename;
            filepath = filename;
            byte[] filedata = System.IO.File.ReadAllBytes(filepath);
            string contentType = Type(filepath);

            var cd = new System.Net.Mime.ContentDisposition
            {
                FileName = filename,
                Inline = false,
            };
            Response.Headers.Add("Content-Disposition", cd.ToString());

            return File(filedata, contentType);
        }

        [HttpGet]
        [Route("Home/delete")]
        public HttpResponseMessage DeleteFile(string fileDir)
        {
            string filename = Path.Combine(Directory.GetCurrentDirectory(),
                                    "files", fileDir);
            string filepath = AppDomain.CurrentDomain.BaseDirectory + filename;
            filepath = filename;
            System.IO.File.Delete(filename);
            var response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            response.Content = new StringContent("File sucessfully deleted");
            return response;
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}
