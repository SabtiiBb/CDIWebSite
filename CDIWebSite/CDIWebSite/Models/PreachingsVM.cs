using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CDIWebSite.DataContext;
using System.ComponentModel.DataAnnotations;

namespace CDIWebSite.Models
{
    public class PreachingsVM : BaseModel
    {
        
        public List<VideoStream> VidList { get; set; }

        public int idVideo { get; set; }

        public string TituloVideo { get; set; }

        public string PredicadorVideo { get; set; }

        public string CitasVideo { get; set; }

        public string DescripcionVideo { get; set; }
        
        public string VideoVideo { get; set; }
    }
}