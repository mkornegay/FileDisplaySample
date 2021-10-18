using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileDisplaySample.Controllers
{
    public class FileDisplayController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public FileContentResult ShowFile()
        {
            //get the content type
            string fileName = "C:\\Users\\Mkornegay\\Downloads\\sample3.pdf";
            string contentType = "";
            new FileExtensionContentTypeProvider().TryGetContentType(fileName, out contentType);

            //get the bytes
            byte[] fileContents = System.IO.File.ReadAllBytes(fileName);


            return new FileContentResult(fileContents, contentType);
        }


    }
}
