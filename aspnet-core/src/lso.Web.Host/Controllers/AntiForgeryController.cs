using Microsoft.AspNetCore.Antiforgery;
using lso.Controllers;

namespace lso.Web.Host.Controllers
{
    public class AntiForgeryController : lsoControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
