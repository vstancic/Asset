using System.Linq;
using Asset.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Asset.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssetController : ControllerBase
    {

        private readonly AssetContext _context;
        private readonly IConfiguration _configuration;
        public AssetController(AssetContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpGet("message")]
        public string Get()
        {
            var asset = new Domain.Asset();
            return _configuration.GetConnectionString("SqlConnectionString");
        }
        
        [HttpGet]
        public IActionResult GetAssets()
        {
            return Ok(_context.Asset.ToList());
        }
    }
}