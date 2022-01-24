﻿using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MatricManagerTests
{
    public class HddMetricsTests 
    {

        [Fact]
        public void HddGetMetricsFromAgent_Result_Ok()
        {
            var controller = new MetricManager.Controllers.HddMetricsController();
            var result = controller.GetMetricsFromAgent(1, TimeSpan.Zero, TimeSpan.Zero);
            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
