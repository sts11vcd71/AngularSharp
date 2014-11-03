using System.Collections.Generic;

namespace AngularSharp.SampleWeb.Models
{
    public class SitePage
    {
        public string Name { get; set; }
        public string PageTitle { get; set; }
        public List<string> ScriptFiles { get; set; }
        public List<SiteMenuItem> MenuItems { get; set; }
    }
}
