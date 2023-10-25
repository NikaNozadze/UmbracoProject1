using Microsoft.AspNetCore.Mvc;

namespace UmbracoProject1.Components
{
    [ViewComponent(Name = "About")]
    public class AboutViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
