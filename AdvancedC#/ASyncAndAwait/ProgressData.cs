using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    internal class ProgressData
    {
        public List<WebsiteDataModel> SiteDownloaded { get; set; }=new List<WebsiteDataModel>();
        public int PercentageCompleted { get; set; }=0;
    }
}
