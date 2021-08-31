using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baitap2.Controllers
{
    public class Demobaitap2Controller : Controller
    {
        // GET: Demobaitap2
        public ActionResult GPT1(String soa, String sob)
        {
            Double a, b;
            String ketqua = " ";
            a = Convert.ToDouble(soa);
            b = Convert.ToDouble(sob);

            if (a == 0)
            {
                ketqua = ("Phuong Trinh Vo Nghiem");
            }
            else
            {
                Double x = -b / a;
                ketqua = ("Vay nghiem cua phuong trinh la:  " + x);
            }

            ViewBag.abc = ketqua;
            return View();
        }
    }
}
