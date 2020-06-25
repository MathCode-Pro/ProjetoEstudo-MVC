using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using System.Collections.Generic;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellersService;

        public SellersController(SellerService sellersService)
        {
            _sellersService = sellersService;
        }

        public IActionResult Index()
        {
            List<Seller> list = _sellersService.FindAll();
            return View(list);
        }
    }
}
