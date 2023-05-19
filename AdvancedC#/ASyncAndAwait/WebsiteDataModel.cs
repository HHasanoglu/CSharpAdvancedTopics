using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    internal class WebsiteDataModel
    {
        #region Ctor
        public WebsiteDataModel(string websiteURL, string webSiteData)
        {
            _WebsiteURL = websiteURL;
            _WebSiteData = webSiteData;
        }

        #endregion

        #region Private Fields

        private string _WebsiteURL;
        private string _WebSiteData;

        #endregion

        #region Public Properties

        public string WebsiteURL { get => _WebsiteURL; set => _WebsiteURL = value; }
        public string WebSiteData { get => _WebSiteData; set => _WebSiteData = value; }

        #endregion


    }
}
