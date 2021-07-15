using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CatalogoEmpleados_CarlosBeltran.Models;
using CatalogoEmpleados_CarlosBeltran.Models.ViewModels;

namespace CatalogoEmpleados_CarlosBeltran.Controllers
{   
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            List<ListEmpleadoViewModel> lst;
            using (CatalogoEmpleados_CarlosBeltranEntities db= new CatalogoEmpleados_CarlosBeltranEntities())
            {
                
                 lst = (from d in db.Empleado
                           select new ListEmpleadoViewModel
                           {
                               IdEmpleado = d.IdEmpleado,
                               Nombre = d.Nombre,
                               Apellido1 = d.Apellido1,
                               Apellido2 = d.Apellido2,
                               FechaNacimiento = d.FechaNacimiento,
                               Sueldo = (float)d.Sueldo,
                               Departamento = d.Departamento
                           }).ToList();
            }
            return View(lst);
        }

        public ActionResult NuevoEmpleado()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NuevoEmpleado(TablaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (CatalogoEmpleados_CarlosBeltranEntities db = new CatalogoEmpleados_CarlosBeltranEntities())
                    {
                        var oTabla = new Empleado();
                        oTabla.IdEmpleado = model.IdEmpleado;
                        oTabla.Nombre = model.Nombre;
                        oTabla.Apellido1 = model.Apellido1;
                        oTabla.Apellido2 = model.Apellido2;
                        oTabla.FechaNacimiento = model.FechaNacimiento;
                        oTabla.Sueldo = model.Sueldo;
                        oTabla.Departamento = model.Departamento;

                        db.Empleado.Add(oTabla);
                        db.SaveChanges();
                    }

                    return Redirect("~/Empleado/");
                }

                return View(model);
                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public ActionResult Editar(int id)
        {

            TablaViewModel model = new TablaViewModel();
            using (CatalogoEmpleados_CarlosBeltranEntities db = new CatalogoEmpleados_CarlosBeltranEntities())
            {
                var oTabla = db.Empleado.Find(id);
                
                model.Nombre = oTabla.Nombre;
                model.Apellido1 = oTabla.Apellido1;
                model.Apellido2 = oTabla.Apellido2;
                model.FechaNacimiento = oTabla.FechaNacimiento;
                model.Sueldo = (float)oTabla.Sueldo;
                model.Departamento = oTabla.Departamento;

                model.IdEmpleado = oTabla.IdEmpleado;

            }
                return View(model);
        }

        [HttpPost]
        public ActionResult Editar(TablaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (CatalogoEmpleados_CarlosBeltranEntities db = new CatalogoEmpleados_CarlosBeltranEntities())
                    {
                        var oTabla = db.Empleado.Find(model.IdEmpleado);

                        oTabla.IdEmpleado = model.IdEmpleado;
                        oTabla.Nombre = model.Nombre;
                        oTabla.Apellido1 = model.Apellido1;
                        oTabla.Apellido2 = model.Apellido2;
                        oTabla.FechaNacimiento = model.FechaNacimiento;
                        oTabla.Sueldo = model.Sueldo;
                        oTabla.Departamento = model.Departamento;

                        db.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }

                    return Redirect("~/Empleado/");
                }

                return View(model);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




        [HttpGet]
        public ActionResult Eliminar(int id)
        {
    
            using (CatalogoEmpleados_CarlosBeltranEntities db = new CatalogoEmpleados_CarlosBeltranEntities())
            {

                var oTabla = db.Empleado.Find(id);
                db.Empleado.Remove(oTabla);
                db.SaveChanges();

            }
            return Redirect("~/Empleado/");
        }


    }
}