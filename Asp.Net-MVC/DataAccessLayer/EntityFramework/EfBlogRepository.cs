using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
	{
		public List<Blog> GetListWithCategory()
		{
			using (Context _context = new Context())
			{
				return _context.Blogs.Include(x=> x.Category).ToList();
			}
		}

		public List<Blog> GetLastThreePosts() {
			using (Context _context = new Context())
			{
				return _context.Blogs.OrderBy(x=>x.BlogID).Take(3).ToList();
			}
		}

        public List<Blog> GetListWithCategoryByWriter(int id)
        {
            using (Context _context = new Context()) 
            {
                return _context.Blogs.Include(x => x.Category).Where(x=>x.WriterID==id).ToList();
            }
        }
    }
}
