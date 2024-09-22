using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BooksService.Controllers
{
    /// <summary>
    /// ���������� ��� �������� �������������� �������������.
    /// </summary>
    /// <remarks>
    /// JWT ����� ����� ������������� �������� �� http://jwtbuilder.jamiekurtz.com/
    /// �������� issuer ��� https://accounts.google.com,
    /// � audience ����� ����� � GoogleJsonWebTokenConfiguration:Audience.
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