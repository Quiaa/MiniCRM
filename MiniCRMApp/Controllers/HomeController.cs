using System.Linq;
using System.Web.Mvc;
using MiniCRMApp.Models;

namespace MiniCRMApp.Controllers
{
    public class HomeController : Controller
    {
        private CrmContext db = new CrmContext(); // Veritabanı bağlantımız

        public ActionResult Index()
        {
            ViewBag.CompanyCount = db.Companies.Count();
            ViewBag.MeetingCount = db.Meetings.Count();

            // Son 5 görüşmeyi tarihe göre tersten sıralayıp alalım
            var recentMeetings = db.Meetings.OrderByDescending(m => m.MeetingDate).Take(5).ToList();

            return View(recentMeetings);
        }
    }
}