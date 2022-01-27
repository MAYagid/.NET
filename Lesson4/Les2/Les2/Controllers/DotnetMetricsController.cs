using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Les2.Controllers
{
    [Route("api/metrics/dotnet")]
    [ApiController]
    public class DotnetMetricsController : ControllerBase
    {
        private readonly ILogger<DotnetMetricsController> _logger;

        public DotnetMetricsController(ILogger<DotnetMetricsController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog встроен");
        }
        [HttpGet("errors-count/{agentId}/from/{fromDate}/to/{toDate}")]
        public IActionResult GetMetrics([FromRoute] int agentId, [FromRoute] TimeSpan fromDate, [FromRoute] TimeSpan toDate)
        {
            _logger.LogInformation("лог работает");
            return Ok();
        }
    }
}
