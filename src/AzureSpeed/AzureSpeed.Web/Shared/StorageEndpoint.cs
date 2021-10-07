using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureSpeed.Web.Shared
{
    public class StorageEndpoint
    {
        public StorageEndpoint()
        {
            this.History = new Queue<LatencyHistoryEntry>();
        }

        public string Url { get; set; }

        public string Location { get; set; }

        public string Name { get; set; }

        public string Icon { get; set; }

        public double Latency { get; set; }

        public Queue<LatencyHistoryEntry> History { get; set; }
    }
}
