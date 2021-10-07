using System.Linq;
using Asset.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Asset.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssetController : ControllerBase
    {

        private readonly AssetContext _context;
        public AssetController(AssetContext context)
        {
            _context = context;
        }

        [HttpGet("message")]
        public string Get()
        {
            var asset = new Domain.Asset();
            return asset.MessageFromAsset();
        }
        
        [HttpGet]
        public IActionResult GetAssets()
        {
            return Ok(_context.Asset.ToList());
        }
    }
}