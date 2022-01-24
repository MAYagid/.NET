using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MatricManagerTests
{
    public class DotnetMetricsTests
    {

        [Fact]
        public void DotnetGetMetricsFromAgent_Result_Ok()
        {
            var controller = new MetricManager.Controllers.DotnetMetricsController();
            var result = controller.GetMetricsFromAgent(1, TimeSpan.Zero, TimeSpan.Zero);
            Assert.IsAssignableFrom<IActionResult>(result);
        }

    }
}
