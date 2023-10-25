using Microsoft.AspNetCore.Mvc;

namespace UmbracoProject1.Components
{
    [ViewComponent(Name = "Header")]
    public class HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
