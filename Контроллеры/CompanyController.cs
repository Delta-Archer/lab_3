using Lab_3.Models;
using System.Linq;
using System.Web.Mvc;

namespace Lab_3.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        MobileContext db = new MobileContext();
        public ActionResult Index()
        {
            return View(db.Companies);
        }
        public ActionResult CompanyDetails(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Companies comp = db.Companies.Find(id);
            if (comp == null)
            {
                return HttpNotFound();
            }
            comp.Mobiles = db.Mobiles.Where(m => m.CompanyId == comp.Id);
            return View(comp);
        }
    }
}