using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Portfolio
{
    public class PortfolioList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
