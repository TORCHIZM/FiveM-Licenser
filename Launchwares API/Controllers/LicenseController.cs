using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Launchwares_API.Models;
using Microsoft.AspNetCore.Http;

namespace Launchwares_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class License : Controller
    {
        private IHttpContextAccessor _accessor;

        public License(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        [HttpGet]
        public IEnumerable<Models.License> Get(string license, string product)
        {
            var ip = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();
            if (license == "" || product == "") yield return null;
            yield return Licenses.GetLicense(product, license, ip);
        }
    }
}