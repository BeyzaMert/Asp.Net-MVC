//using BusinessLayer.Concrete;
//using EntityLayer.Concrete;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace CoreDemo.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ValuesController : ControllerBase
//    {
//        CategoryManager categoryManager = new CategoryManager();
//        [HttpPost]
//        [Route("create-category")]
//        public Category CreateCategory(Category category)
//        {

//            categoryManager.CategoryAdd(category);

          
//            return category;
//        }
//    }
//}