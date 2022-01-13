using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MatricManagerTests
{
    public class UnitTest1
    {
        [Fact]
        public void CpuGetMetricsFromAgent_Result_Ok()
        {
            var controller = new MetricManager.Controllers.CpuMetricsController();
            var result = controller.GetMetricsFromAgent(1, TimeSpan.Zero, TimeSpan.Zero);
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void HddGetMetricsFromAgent_Result_Ok()
        {
            var controller = new MetricManager.Controllers.HddMetricsController();
            var result = controller.GetMetricsFromAgent(1, TimeSpan.Zero, TimeSpan.Zero);
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void RamGetMetricsFromAgent_Result_Ok()
        {
            var controller = new MetricManager.Controllers.RamMetricsController();
            var result = controller.GetMetricsFromAgent(1, TimeSpan.Zero, TimeSpan.Zero);
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void NetworkGetMetricsFromAgent_Result_Ok()
        {
            var controller = new MetricManager.Controllers.NetworkMetricsController();
            var result = controller.GetMetricsFromAgent(1, TimeSpan.Zero, TimeSpan.Zero);
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void DotnetGetMetricsFromAgent_Result_Ok()
        {
            var controller = new MetricManager.Controllers.DotnetMetricsController();
            var result = controller.GetMetricsFromAgent(1, TimeSpan.Zero, TimeSpan.Zero);
            Assert.IsAssignableFrom<IActionResult>(result);
        }

    }
}
