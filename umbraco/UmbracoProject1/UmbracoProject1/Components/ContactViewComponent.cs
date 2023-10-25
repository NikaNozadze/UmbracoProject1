using Microsoft.AspNetCore.Mvc;

namespace UmbracoProject1.Components
{
    [ViewComponent(Name = "Contact")]
    public class ContactViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
