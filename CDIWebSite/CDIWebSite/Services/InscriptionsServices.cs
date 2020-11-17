using CDIWebSite.DataContext;
using CDIWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;

namespace CDIWebSite.Services
{
    public class InscriptionsServices
    {
        CDIWebSiteToEntitiesDB db = new CDIWebSiteToEntitiesDB();

        public void addInscription(InscriptionsVM model)
        {
                Inscripcione Inscription = new Inscripcione();
                Inscription.IdPersona = model.IdPersona;
                Inscription.IdEvento = model.IdEvento;
                Inscription.Activo = 1;
                db.Inscripciones.Add(Inscription);
                db.SaveChanges();

                AddCupo(model);
        }

        public void addInscriptionIfUserExist(string Correo, int idEvento)
        {
            Persona s = db.Personas.Where(x => x.Correo == Correo).Single();
            Inscripcione inscr = new Inscripcione();
            inscr.IdEvento = idEvento;
            inscr.IdPersona = s.IdPersona;
            inscr.Activo = 1;
            db.Inscripciones.Add(inscr);
            db.SaveChanges();
        }

        //------------------------------------------ FUNCTIONS ------------------------------------------

        public InscriptionsVM addPersona(InscriptionsVM p)
        {
            Persona h = new Persona();
            h.Nombre = p.Nombre;
            h.Apellido = p.Apellido;
            h.Correo = p.Correo;
            h.Edad = p.Edad;
            h.FechaNac = p.FechaNac;
            h.FechaRegistro = DateTime.Now;
            h.Sexo = p.Sexo;
            h.NContacto = p.NContacto;

            db.Personas.Add(h);
            db.SaveChanges();

            var last = db.Personas.OrderByDescending(x => x.IdPersona).First();
            p.IdPersona = last.IdPersona;

            return p;
        }

        public bool verifyIfExistMail(string correo)
        {
            int exist = db.Personas.Where(x => x.Correo == correo).Count();
            if (exist > 0)
            {
                return true;
            }
            return false;
        }

        public void AddCupo(InscriptionsVM model)
        {
            Evento e = db.Eventoes.Where(x => x.IdEvento == model.IdEvento).Single();
            Cupo c = db.Cupoes.Where(x => x.IdCupo == e.IdCupo).Single();

            c.EnUso = c.EnUso + 1;
            c.Disponibles = c.Disponibles - 1;

            if(c.EnUso == c.CantCupo)
            {
                c.StatusOnOff = 0;
            }

            db.Entry(c).State = EntityState.Modified;
            db.SaveChanges();
        }

        public bool CuposState(int idEvento)
        {
            Evento e = db.Eventoes.Where(x => x.IdEvento == idEvento).Single();
            Cupo c = db.Cupoes.Where(x => x.IdCupo == e.IdCupo).Single();
            if(c.StatusOnOff == 1)
            {
                return true;
            }

            return false;
        }

        public List<SelectListItem> Gender()
        {
            List<SelectListItem> ListaGenero = new List<SelectListItem>();
            ListaGenero.Add(new SelectListItem { Text = "Femenino", Value = "F" });
            ListaGenero.Add(new SelectListItem { Text = "Masculino", Value = "M" });

            return ListaGenero;
        }

        public List<SelectListItem> Edades()
        {
            List<SelectListItem> ListEdades = new List<SelectListItem>();
            for(var s = 15; s<100; s++)
            {
                ListEdades.Add(new SelectListItem { Text = s + " años", Value = s.ToString() });
            }

            return ListEdades;
        }

        public int GetPeId(string Correo)
        {
            Persona p = db.Personas.Where(x => x.Correo == Correo).Single();

            return p.IdPersona;
        }

    }
}