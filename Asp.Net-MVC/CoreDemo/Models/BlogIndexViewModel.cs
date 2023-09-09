using EntityLayer.Concrete;
using System.Collections.Generic;

namespace CoreDemo.Models
{
    public class BlogIndexViewModel
    {
        public List<Blog> Blogs { get; set; }

        public List<Category> Categories { get; set; }
    }
}
