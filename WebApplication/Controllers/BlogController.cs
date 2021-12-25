using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using BusinessLogic;
using BusinessObject;

namespace WebApplication.Controllers
{
    public class BlogController : ApiController
    {
        // GET: Blog

        public List<blogBO> GetAllBlog()
        {
            List<blogBO> model = new blogBL().GetBlog();
            return model;
        }





        public HttpResponseMessage PostBlog(blogBO item)
        {
            item = new blogBL().PostBlog(item);
            var response = Request.CreateResponse<blogBO>(HttpStatusCode.Created, item);
            string uri = Url.Link("DefaultApi", new { id = item.blog_id});
            response.Headers.Location = new Uri(uri);

            return response;

        }

        public HttpResponseMessage PutBlog(blogBO item)
        {
            item = new blogBL().PutBlog(item);
            var response = Request.CreateResponse<blogBO>(HttpStatusCode.Created, item);
            string uri = Url.Link("DefaultApi", new { id = item.blog_id });
            response.Headers.Location = new Uri(uri);

            return response;

        }

        public HttpResponseMessage DeleteBlog(blogBO item)
        {
            item = new blogBL().DeleteBlog(item);
            var response = Request.CreateResponse<blogBO>(HttpStatusCode.Created, item);
            string uri = Url.Link("DefaultApi", new { id = item.blog_id });
            response.Headers.Location = new Uri(uri);

            return response;

        }
    }
}