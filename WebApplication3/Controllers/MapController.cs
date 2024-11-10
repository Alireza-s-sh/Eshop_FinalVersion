using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyEshop.Data;

namespace WebApplication3.Controllers
{
    public class MapController : Controller
    {
        private MyEshopContext _context;

        public MapController(MyEshopContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ShowNearbyProducts(double latitude, double longitude)
        {
            try
            {
                var products = _context.Products.ToList();

                // فیلتر کردن محصولات نزدیک به کاربر
                var nearbyProducts = products
                    .Where(p => CalculateDistance(p.Latitude, p.Longitude, latitude, longitude) < 8) // شعاع 8 کیلومتر
                    .ToList();

                // بازگشت به نمای محصولات نزدیک
                return PartialView("_nearbyproducts", nearbyProducts);
            }
            catch (Exception ex)
            {
                // لاگ‌گیری خطا
                Console.WriteLine(ex.Message);
                return StatusCode(500, "Internal server error");
            }
        }
        private double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            // استفاده از فرمول Haversine برای محاسبه فاصله بین دو نقطه جغرافیایی
            var R = 6371; // شعاع زمین به کیلومتر
            var dLat = (lat2 - lat1) * (Math.PI / 180);
            var dLon = (lon2 - lon1) * (Math.PI / 180);
            var a =
                Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Cos(lat1 * (Math.PI / 180)) * Math.Cos(lat2 * (Math.PI / 180)) *
                Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            var distance = R * c;

            return distance;
        }
    }
}