//using BusinessLayer.Concrete;
//using EntityLayer.Concrete;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System.Linq;

//namespace BlogApiDemo.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ValuesController : ControllerBase
//    {
//        CategoryManager categoryManager = new CategoryManager();
//        [HttpPost]
//        [Route("create-category")]
//        public Category CreateCategory(string categoryName,string categoryDescription,bool categoryStatus)
//        {
//            Category category = new Category();
//            category.CategoryName = categoryName;
//            category.CategoryDescription = categoryDescription;
//            category.CategoryStatus = categoryStatus;
//            categoryManager.CategoryAdd(category);


//            return category;
//        }

//        [HttpDelete]
//        [Route("delete-category")]

//        public Category DeleteCategory(int categoryID)
//        {
//            Category category = new Category();
//            category.CategoryID = categoryID;
           
//            categoryManager.CategoryDelete(category);


//            return category;
//        }
//        [HttpPut]
//        [Route("update-category")]

//        public Category UpdateCategory(int categoryID,string categoryName, string categoryDescription, bool categoryStatus)
//        {
//            Category category = new Category();
//            category.CategoryID=categoryID;
//            category.CategoryName = categoryName;
//            category.CategoryDescription = categoryDescription;
//            category.CategoryStatus = categoryStatus;
//            categoryManager.CategoryUpdate(category);


//            return category; ;

//        }

//        [HttpDelete]
//        [Route("delete-categoryy")]

//        public Category DeleteCategoryy(int categoryID)
//        {
//            Category category = new Category();
//            category.CategoryID = categoryID;

//            var deger=categoryManager.GetById(categoryID);
//            deger.IsActive = false;

//            categoryManager.CategoryDelete(category);


//            return category;
//        }


//    }
//}
