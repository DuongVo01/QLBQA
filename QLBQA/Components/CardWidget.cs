using Microsoft.AspNetCore.Mvc;
using QLBQA.Data;
using QLBQA.Infrastructure;
using QLBQA.Models;

namespace QLBQA.Components
{
    public class CardWidget : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            return View(HttpContext.Session.GetJson<Cart>("cart"));
        }
    }
}
