using AzureSpeed.Web.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureSpeed.Web.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StorageController : ControllerBase
    {
        private readonly ILogger<StorageController> _logger;

        public StorageController(ILogger<StorageController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<StorageEndpoint> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new StorageEndpoint
            {
                Name = ""
            })
            .ToArray();
        }
    }
}
