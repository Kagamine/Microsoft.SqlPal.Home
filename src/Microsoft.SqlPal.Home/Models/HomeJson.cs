using System.Collections.Generic;

namespace Microsoft.SqlPal.Home.Models
{
    public class HomeJson
    {
        public string Title { get; set; }

        public string SubTitleLine1 { get; set; }

        public string SubTitleLine2 { get; set; }

        public string DiscussionLink { get; set; }

        public string DocumentSiteLink { get; set; }

        public string ExampleLink { get; set; }

        public string TutorialsLink { get; set; }

        public string GitHubLink { get; set; }

        public IEnumerable<Company> Companies { get; set; }

        public IEnumerable<Highlight> Highlights { get; set; }
    }
}
