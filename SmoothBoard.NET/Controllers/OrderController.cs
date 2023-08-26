using Microsoft.AspNetCore.Mvc;
using SmoothBoard.NET.Models;

namespace SmoothBoard.NET.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Creëer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Creëer(OrderModel order)
        {
            if (ModelState.IsValid)
            {
                ViewBag.SuccessMessage = "Bestelling succesvol aangemaakt!";
            }

            return View(order);
        }
    }
}