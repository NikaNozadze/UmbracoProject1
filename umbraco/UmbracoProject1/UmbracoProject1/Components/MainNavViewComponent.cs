using Microsoft.AspNetCore.Mvc;

namespace UmbracoProject1.Components
{
    [ViewComponent(Name = "MainNav")]
    public class MainNavViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
