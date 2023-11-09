using Microsoft.AspNetCore.Mvc;
using SalesWebMvc2.Data;
using SalesWebMvc2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc2.Controllers
{
    public class SellersController : Controller
    {
        private readonly SalesWebMvc2Context _context;

        public SellersController(SalesWebMvc2Context context)
        {
            _context = context;
        }

        public IActionResult Index(int? id)
        {

            return View();
        }
    }
}
