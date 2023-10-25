using Microsoft.AspNetCore.Mvc;

namespace UmbracoProject1.Components
{
    [ViewComponent(Name = "Portfolio")]
    public class PortfolioViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
