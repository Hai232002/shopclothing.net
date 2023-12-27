using ClothesWebNET.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ClothesWebNET.Controllers
{
    
    public class HUYNHVANHAI : Controller
    {
        private CLOTHESEntities db = new CLOTHESEntities();
        //huynhvanhai
        public ActionResult index()
        {

            return View();
        }
        public ActionResult hvh_2120110218()
        {
            return View(db.asp_2120110218.ToList());
        }
    }
  
}