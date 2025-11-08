using NewAfrica.Models;
using NewAfrica.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
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
            List<SOUSFAMILL> listcategds = db.SOUSFAMILL
                .Where(sf=> sf.idsf >0)
                .OrderBy(sf => sf.ordresf)
                .ToList();
            return View(listcategds);
        }

        public ActionResult IndexProds()
        {
            var listprods = (from i in db.ITEM
                             join sf in db.SOUSFAMILL on i.idsf equals sf.idsf
                             where i.idsf > 0
                             select new ItemVm
                             {
                                 iditem = i.iditem,
                                 designation = i.designation,
                                 designdetails = i.designdetails,
                                 prixitem = i.prixitem,
                                 path1 = i.path1,
                                 path2 = i.path2,
                                 path3 = i.path3,
                                 idsf = sf.idsf,
                                 libsf = sf.libsf,
                                 ordresf = sf.ordresf
                             })
             .ToList();

            return View(listprods);
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
                SOUSFAMILL categnow = db.SOUSFAMILL.Where(c => c.idsf == idcateg).FirstOrDefault();
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
                    //System.IO.File.Delete(Server.MapPath(Path.Combine("~/Content/images/", oldpath)));
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

        public ActionResult DetailProd(int idprod)
        {
            ITEM prod = db.ITEM.Where(i => i.iditem == idprod).FirstOrDefault();
            List<SOUSFAMILL> listsf = db.SOUSFAMILL.OrderBy(sf => sf.ordresf).ToList();
            ViewBag.listsf = listsf;     
            return View(prod);
        }

        public ActionResult DetailsProd(int idprod)
        {
            ITEM prod = db.ITEM.Where(i => i.iditem == idprod).FirstOrDefault();
            List<SOUSFAMILL> listsf = db.SOUSFAMILL.OrderBy(sf => sf.ordresf).ToList();
            ViewBag.listsf = listsf;
            return View(prod);
        }
        [HttpPost]
        public ActionResult UpdateProd(long idprod, long idcateg,int numimg, string oldpath, string typfile, string designation, string detailsprod, HttpPostedFileBase fileimg)
        {

            //Save
            try
            {
                ITEM prodnow = db.ITEM.SingleOrDefault(i => i.iditem == idprod);
                prodnow.designation = designation;
                prodnow.designdetails = detailsprod;
                prodnow.idsf = idcateg;
                if (fileimg != null && fileimg.ContentLength > 0)
                {
                    string nomfic = DateTime.Now.ToString("yyyyMMMdd") + DateTime.Now.ToString("hhmmss") + Path.GetFileName(fileimg.FileName);
                    fileimg.SaveAs(Server.MapPath(Path.Combine("~/Content/images/", nomfic)));
                    switch (numimg)
                    {
                        default: case 1: prodnow.path1 = nomfic; break;
                        case 2: prodnow.path2 = nomfic; break;
                            //case 3: categnow.path3 = nomfic; break;
                            //case 4: categnow.path4 = nomfic; break;
                    }

                    //Delete Old image
                    //System.IO.File.Delete(Server.MapPath(Path.Combine("~/Content/images/", oldpath)));
                }

                db.Entry(prodnow).State = EntityState.Modified;
                db.SaveChanges();
                TempData["modifimg"] = "success";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                TempData["modifimg"] = "fail";
            }
            return RedirectToAction("IndexProds");
        }
    }
}