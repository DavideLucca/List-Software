using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aparel_List.Models;

namespace Aparel_List.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if(Session["usuarioLogadoId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(tb_login u)
        {
            if(ModelState.IsValid)
            {
                using(DB_GENERALEntities dc = new DB_GENERALEntities())
                {
                    var v = dc.tb_login.Where(a => a.nomeUsuario.Equals(u.nomeUsuario) && a.senha.Equals(u.senha)).FirstOrDefault();
                    if(v != null)
                    {
                        Session["usuarioLogadoID"] = v.Id.ToString();
                        Session["nomeUsuarioLogado"] = v.nomeUsuario.ToString();
                        return RedirectToAction("Index");
                    }
                }
            }

            return View(u);
        }

        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registro(tb_login u)
        {
            {
                if (ModelState.IsValid)
                {
                    using(DB_GENERALEntities dc = new DB_GENERALEntities())
                    {
                        dc.tb_login.Add(u);
                        dc.SaveChanges();
                        ModelState.Clear();
                        u = null;
                        ViewBag.Message = "Usuário registrado com sucesso.";
                    }
                }

                return View(u);
            }
        }
    }
}