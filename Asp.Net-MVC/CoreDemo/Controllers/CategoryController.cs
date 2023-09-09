using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Controllers
{
	public class CategoryController : Controller
	{
		CategoryManager cm = new CategoryManager(new EfCategoryRepository());
		public IActionResult Index()
		{
			var values = cm.GetList();
			return View(values);
		}

		public IActionResult Deneme()
		{
			using (Context context = new DataAccessLayer.Concrete.Context())
			{
				return Ok(context.Blogs.ToList());
			}
		}
	}
}
