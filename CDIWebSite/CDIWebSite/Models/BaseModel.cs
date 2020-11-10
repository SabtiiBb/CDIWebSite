using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace CDIWebSite.Models
{
    public class BaseModel
    {
        public int Page { get; set; }
        public int RegPerPage { get; set; }
        public int TotalReg { get; set; }
        public RouteValueDictionary ValoresQueryString { get; set; }
    }
}