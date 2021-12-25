using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAcess;

namespace BusinessLogic
{
    public class blogBL
    {
        public List<blogBO> GetBlog()
        {
            return new blogModel().GetBlogList();
        }

        public blogBO PostBlog(blogBO item)
        {
            return new blogModel().createBlog(item);
        }

        public blogBO PutBlog(blogBO item)
        {
            return new blogModel().UpdateBlog(item);
        }

        public blogBO DeleteBlog(blogBO item)
        {
            return new blogModel().DeleteStuff(item);
        }
    }
}
