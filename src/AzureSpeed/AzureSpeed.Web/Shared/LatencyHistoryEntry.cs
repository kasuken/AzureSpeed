using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureSpeed.Web.Shared
{
    public class LatencyHistoryEntry
    {
        public DateTime Timestamp { get; set; }

        public double Latency { get; set; } 
    }
}
