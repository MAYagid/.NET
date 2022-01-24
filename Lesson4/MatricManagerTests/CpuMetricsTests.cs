using MetricManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using Xunit;


namespace MatricManagerTests
{
    public class CpuMetricsTests
    {
        private Mock<ILogger<CpuMetricsController>> _loggerMock;
        private Mock<MetricAgent.DAL.INetworkMetricRepository> _cpuMetricRepositoryMock;


        [Fact]
        public void CpuGetMetricsFromAgent_Result_Ok()
        {
            var controller = new MetricManager.Controllers.CpuMetricsController();
            var result = controller.GetMetricsFromAgent(1, TimeSpan.Zero, TimeSpan.Zero);
            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
