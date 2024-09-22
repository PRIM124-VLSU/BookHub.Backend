using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BooksService.Controllers
{
    /// <summary>
    /// Контроллер для проверки аутентификации пользователей.
    /// </summary>
    /// <remarks>
    /// JWT токен можно сгенерировать например на http://jwtbuilder.jamiekurtz.com/
    /// заполняя issuer как https://accounts.google.com,
    /// а audience можно взять в GoogleJsonWebTokenConfiguration:Audience.
    /// </remarks>
    [ApiController]
    public class BaseController : Controller
    {
        [HttpGet]
        [Route("index")]
        public IActionResult Index()
        {
            return Ok("You joined Books.Service index page.");
        }

        [Authorize]
        [HttpGet]
        [Route("lk")]
        public IActionResult GetUserLK()
        {
            return Ok("You joined Books.Service user page.");
        }

        [Authorize(Policy = "Admin")]
        [HttpGet]
        [Route("adminLK")]
        public IActionResult GetAdminLK()
        {
            return Ok("You joined Books.Service admin page.");
        }
    }
}