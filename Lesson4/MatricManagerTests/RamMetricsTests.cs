using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MatricManagerTests
{
    public class RamMetricsTests
    {

        [Fact]
        public void RamGetMetricsFromAgent_Result_Ok()
        {
            var controller = new MetricManager.Controllers.RamMetricsController();
            var result = controller.GetMetricsFromAgent(1, TimeSpan.Zero, TimeSpan.Zero);
            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
