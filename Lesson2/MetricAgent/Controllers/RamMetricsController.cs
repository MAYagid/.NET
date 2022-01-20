﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricAgent.Controllers
{
    [Route("api/metrics/ram")]
    [ApiController]
    public class RamMetricsController : ControllerBase
    {
        [HttpGet("available/{agentId}/from/{fromDate}/to/{toDate}")]
        public IActionResult GetMetrics([FromRoute] int agentId, [FromRoute] TimeSpan fromDate, [FromRoute] TimeSpan toDate)
        {
            return Ok();
        }
    }
}
