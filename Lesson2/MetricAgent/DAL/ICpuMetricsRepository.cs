using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetricAgent.Models;

namespace MetricAgent.DAL
{
    interface ICpuMetricsRepository
    {
        public interface ICpuMetricsRepository : IRepository<CpuMetric>
        {

        }
    }
}
