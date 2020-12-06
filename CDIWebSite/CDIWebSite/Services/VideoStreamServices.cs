using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CDIWebSite.DataContext;
using CDIWebSite.Models;

namespace CDIWebSite.Services
{
    public class VideoStreamServices
    {
        CDIWebSiteToEntitiesDB db = new CDIWebSiteToEntitiesDB();

        public PreachingsVM GetList(int pagina)
        {
            PreachingsVM model = new PreachingsVM();
            int cantidadRegistrosPorPagina = 9;
            List<VideoStream> ListadoDeVideos = db.VideoStreams
                .Where(x => x.Activo == 1)
                .OrderByDescending(x => x.IdVideo)
                .Skip((pagina - 1) * cantidadRegistrosPorPagina)
                .Take(cantidadRegistrosPorPagina).ToList();

            model.VidList = ListadoDeVideos;
            model.RegPerPage = cantidadRegistrosPorPagina;
            model.Page = pagina;
            model.TotalReg = db.VideoStreams.Where(x => x.Activo == 1).Count();
            return model;
        }

        public PreachingsVM GetVideo (int id)
        {
            PreachingsVM model = new PreachingsVM();
            VideoStream bd = db.VideoStreams
                .Where(x => x.IdVideo == id).Single();

            model.idVideo = bd.IdVideo;
            model.TituloVideo = bd.Titulo;
            model.PredicadorVideo = bd.Predicador;
            model.CitasVideo = bd.Citas;
            model.DescripcionVideo = bd.Descripcion;
            model.VideoVideo = bd.iFrameSection;

            return model;

        }

    }
}