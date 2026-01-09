using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace untyStore.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly IBootsRepository bootsRepository;

        public SearchController(IBootsRepository bootsRepository)
        {
            this.bootsRepository = bootsRepository;
        }

        public IActionResult Index(string query)
        {
            var boots = bootsRepository.GetAllByTitle(query);
            return View(boots);
        }
    }
}
