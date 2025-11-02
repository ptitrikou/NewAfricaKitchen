using NewAfrica.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewAfrica.Controllers.Admin
{
    public class AdminController : Controller
    {
        AdminWebModel db = new AdminWebModel();

        // GET: Admin
        public ActionResult IndexAdmin()
        {
            List<SOUSFAMILL> listcategds = db.SOUSFAMILL.Where(sf=> sf.idsf >0).ToList();
            return View(listcategds);
        }

        public ActionResult DetailCateg(int idcateg)
        {
            SOUSFAMILL categ = db.SOUSFAMILL.Where(i => i.idsf == idcateg).FirstOrDefault();
            return View(categ);
        }

        [HttpPost]
        public ActionResult UpdateCateg(long idcateg, int numimg, string oldpath, string typfile, string libcateg, string detcateg, HttpPostedFileBase fileimg)
        {
           
            //Save
            try
            {
                SOUSFAMILL categnow = db.SOUSFAMILL.Find(idcateg);
                categnow.libsf = libcateg;
                categnow.detsf = detcateg;
                if (fileimg != null && fileimg.ContentLength > 0)
                {
                    string nomfic = DateTime.Now.ToString("yyyyMMMdd") + DateTime.Now.ToString("hhmmss") + Path.GetFileName(fileimg.FileName);
                    fileimg.SaveAs(Server.MapPath(Path.Combine("~/Content/images/", nomfic)));
                    switch (numimg)
                    {
                        default: case 1: categnow.imgsf = nomfic; break;
                        case 2: categnow.imgsf2 = nomfic; break;
                            //case 3: categnow.path3 = nomfic; break;
                            //case 4: categnow.path4 = nomfic; break;
                    }

                    //Delete Old image
                    System.IO.File.Delete(Server.MapPath(Path.Combine("~/Content/images/", oldpath)));
                }

                db.Entry(categnow).State = EntityState.Modified;
                db.SaveChanges();
                TempData["modifimg"] = "success";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                TempData["modifimg"] = "fail";
            }
            return RedirectToAction("IndexAdmin");
        }
    }
}