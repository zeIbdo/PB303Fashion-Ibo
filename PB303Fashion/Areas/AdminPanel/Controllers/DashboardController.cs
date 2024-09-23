using Microsoft.AspNetCore.Mvc;
using PB303Fashion.DataAccessLayer;

namespace PB303Fashion.Areas.AdminPanel.Controllers
{
    public class DashboardController : AdminController
    {
        private readonly AppDbContext _dbContext;

        public DashboardController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var categories = _dbContext.Categories.ToList();
            return View(categories);
        }
    }
}
