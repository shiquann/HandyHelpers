using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandyHelper.Models;
using HandyHelper.Data;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using HandyHelper.ViewModels;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Authorization;

namespace HandyHelper.Controllers
{

    public class HomeController : Controller
    {
        private ApplicationDbContext context;

        private IHostingEnvironment _environment;

        public HomeController(ApplicationDbContext dbContext, IHostingEnvironment environment)
        {
            context = dbContext;
            _environment = environment;
        }

        public IActionResult Index()
        {
            IList<Job> jobs = context.Jobs.ToList();
            return View(jobs);
        }
        public IActionResult Add()
        {
            AddJobViewModel addJobViewModel = new AddJobViewModel();
            return View(addJobViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddJobViewModel addJobViewModel, ICollection<IFormFile> ImageName)
        {
            var uploads = Path.Combine(_environment.WebRootPath, "images");
            foreach (var file in ImageName)
            {
                if (file.Length > 0)
                {
                    using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                        addJobViewModel.ImageName = file.FileName;
                    }
                }
            }



            if (ModelState.IsValid)
            {

                Job newJob = new Job
                {
                    Id = addJobViewModel.Id,
                    PostingTitle = addJobViewModel.PostingTitle,
                    Discription = addJobViewModel.Discription,
                    Price = addJobViewModel.Price,
                    ImageName = addJobViewModel.ImageName,
                    City = addJobViewModel.City,
                    ZipCode = addJobViewModel.ZipCode,
                    Email = addJobViewModel.Email,
                    PhoneNumber = addJobViewModel.PhoneNumber,
                    States = addJobViewModel.JobState
                };
                context.Jobs.Add(newJob);
                context.SaveChanges();

                return Redirect("/");

            }
            return View(addJobViewModel);
        }

        public IActionResult JobPage([FromRoute] int Id)
        {
            var jobs = context.Jobs.Find(Id);
           
            return View(jobs);
        }
    }

}
    