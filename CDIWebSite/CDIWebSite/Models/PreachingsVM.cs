using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CDIWebSite.DataContext;

namespace CDIWebSite.Models
{
    public class PreachingsVM : BaseModel
    {
        public List<VideoStream> VidList { get; set; }
    }
}