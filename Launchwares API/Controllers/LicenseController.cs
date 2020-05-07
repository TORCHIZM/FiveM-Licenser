using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Launchwares_API.Firebase;
using Launchwares_API.Models;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System.Text;

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
            if (license == string.Empty || product == string.Empty) yield return null;
            yield return Licenses.GetLicense(product, license, ip);
        }
    }
}