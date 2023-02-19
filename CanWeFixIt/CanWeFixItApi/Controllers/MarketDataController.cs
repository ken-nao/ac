using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CanWeFixItService;

namespace CanWeFixItApi.Controllers
{
    [ApiController]
    [Route("v1/marketdata")]
    public class MarketDataController : ControllerBase
    {
        private readonly IDatabaseService _database;

        public MarketDataController(IDatabaseService database)
        {
            _database = database;
        }
		// GET
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MarketDataDto>>> Get()
        {
            return Ok(_database.MarketData().Result);
        }
    }

    [ApiController]
    [Route("v1/valuations")]
    public class ValuationController : ControllerBase
    {
        private readonly IDatabaseService _database;

        public ValuationController(IDatabaseService database)
        {
            _database = database;
        }
		
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MarketValuation>>> Get()
        {
            return Ok(_database.MarketValuation().Result);
        }
    }
}