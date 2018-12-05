﻿using System;
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
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;

namespace CSCI_3600_Group_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFileProvider _fileProvider;  

        public HomeController(IFileProvider fileProvider)  
        {  
            _fileProvider = fileProvider;  
        }  
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult UserHome()
        {
            var filepath = _fileProvider.GetDirectoryContents($"/bukit/files/{this.User.Identity.Name}");
            var outputFileList = new List<FileModel>();
            var i = 0;
            foreach (var item in filepath)
            {
                FileInfo file = new System.IO.FileInfo(item.PhysicalPath);
                outputFileList.Add(new FileModel());
                outputFileList[i].Name = file.Name;
                outputFileList[i].DisplayName = file.Name;
                outputFileList[i].Size = file.Length;
                outputFileList[i].FileType = file.Extension;
                outputFileList[i].FontAwesomeFileType = file.Extension;
                outputFileList[i].LastModified = file.LastWriteTimeUtc;
                outputFileList[i].Owner = User.Identity.Name;
                i++;
            }
           
            //foreach (var file in files)
            //{
            //    outputFileList.Add(new FileModel());
            //    outputFileList[i].Name = file.Name;
            //    outputFileList[i].DisplayName = file.Name;
            //    outputFileList[i].Size = file.Length;
            //    outputFileList[i].FileType = file.Extension;
            //    outputFileList[i].FontAwesomeFileType = file.Extension;
            //    outputFileList[i].LastModified = file.LastWriteTimeUtc;
            //    outputFileList[i].Owner = User.Identity.Name;
            //    i++;
            //}
            return View(outputFileList);
        }

        public String Type(String filepath)
        {
            string contentType;
            new FileExtensionContentTypeProvider().TryGetContentType(filepath, out contentType);
            return contentType ?? "application/octet-stream";
        }

        [HttpGet]
        [Route("Home/Download")]
        public ActionResult DownloadFile(string fileName)
        {
            string filepath = _fileProvider.GetFileInfo($"/bukit/files/{this.User.Identity.Name}/{fileName}").PhysicalPath;
            byte[] filedata = System.IO.File.ReadAllBytes(filepath);
            string contentType = Type(filepath);

            var cd = new System.Net.Mime.ContentDisposition
            {
                FileName = fileName,
                Inline = false,
            };
            Response.Headers.Add("Content-Disposition", cd.ToString());

            return File(filedata, contentType);
        }
        [HttpGet]
        [Route("Home/View")]
        public ActionResult ViewFile(string fileName)
        {
            string filepath = _fileProvider.GetFileInfo($"/bukit/files/{this.User.Identity.Name}/{fileName}").PhysicalPath;
            FileInfo fileInfo = new System.IO.FileInfo(filepath);
            IFileInfo file = _fileProvider.GetFileInfo(filepath);
            FileStream fileStream = new System.IO.FileStream(filepath, FileMode.Open);
            //var file = new System.IO.FileInfo(filepath);
            string contentType = Type(filepath);

            var cd = new System.Net.Mime.ContentDisposition
            {
                FileName = fileName,
                Inline = true,
            };
            Response.Headers.Add("Content-Disposition", cd.ToString());

            
            return File(fileStream, contentType);

            
/*            if (validForViewing(contentType))
            {
                return File(file.CreateReadStream(), contentType, file.Name);
            }

            else
            {
                UnviewableFileModel FileUnviewable = new UnviewableFileModel();
                return View(FileUnviewable);
            }*/
        }
        [Authorize]
        [HttpGet]
        [Route("Home/Delete")]
        public HttpResponseMessage DeleteFile(string fileName)
        {
            //string filepath = Path.Combine(Directory.GetCurrentDirectory(), "bukit", "files", this.User.Identity.Name, fileDir);
            var file = _fileProvider.GetFileInfo($"/bukit/files/{this.User.Identity.Name}/{fileName}").PhysicalPath;
            var fileInfo = new System.IO.FileInfo(file);

            fileInfo.Delete();

            var response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            response.Content = new StringContent("File sucessfully deleted");
            return response;
        }

        [HttpPost("Home/Upload")]
        public async Task<IActionResult> Upload(string fileName, List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            string incompletePath = _fileProvider.GetFileInfo($"/bukit/files/{this.User.Identity.Name}/{fileName}").PhysicalPath;

            foreach (var formFile in files)
            {
                
                if (formFile.Length >= 0)
                {
                    string filePath = incompletePath + '/' + formFile.FileName;
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return RedirectToAction("UserHome");
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

        private bool validForViewing(string type)
        {
            switch(type){
                case "application/octet-stream":
                    return true;
                case "application/json":
                    return true;
                case "text/plain":
                    return true;
                default:
                    return isVideoOrImage(type);
            }
        }

        private bool isVideoOrImage(string type)
        {
            if (type.Contains("video/") || type.Contains("image/"))
                return true;
            else
                return false;
        }
    }
}
