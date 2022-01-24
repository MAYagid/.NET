using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MatricManagerTests
{
    public class NetworkMetricsTests
    {

        [Fact]
        public void NetworkGetMetricsFromAgent_Result_Ok()
        {
            var controller = new MetricManager.Controllers.NetworkMetricsController();
            var result = controller.GetMetricsFromAgent(1, TimeSpan.Zero, TimeSpan.Zero);
            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
