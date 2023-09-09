using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System.Linq;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminMessageController : Controller
    {
      

        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        Context c = new Context();
        public IActionResult Inbox()
        {
            //var username = User.Identity.Name;
            //var usermail = c.Users.Where(x=> x.UserName == username).Select(y=> y.UserMail).FirstOrDefault();   
            //var writerID= c.Writers.Where(x=>x.WriterMail==usermail).Select(y => y.WriterID).FirstOrDefault();
            //var values= mm.GetInboxListWithWriter(writerID);
            //return View(values);
            return View();
        }
    }
}
