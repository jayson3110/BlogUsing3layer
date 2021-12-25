

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAcess
{
    public class blogModel
    {
        public SqlConnection con = new SqlConnection("data source=JAYSON\\SQLEXPRESS; database=Blog; integrated security=SSPI; MultipleActiveResultSets=True");

        public List<blogBO> GetBlogList()
        {

            SqlCommand cmd = new SqlCommand();
            var model = new List<blogBO>();

            cmd.Connection = con;
            con.Open();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SelectBlog";

            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {

                var blog = new blogBO();
                blog.blog_id += (int)sdr["blog_id"];
                blog.blog_Title += sdr["blog_Title"];
                blog.blog_categories_name += sdr["blog_categories_name"];
                blog.blog_Decription += sdr["blog_categories_name"];


                model.Add(blog);



            }
            con.Close();
            return model;

        }

        public blogBO createBlog(blogBO item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            con.Open();
            try
            {

                SqlCommand cm = new SqlCommand("InsertValue", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add(new SqlParameter("@blog_id", item.blog_id));
                cm.Parameters.Add(new SqlParameter("@blog_Title", item.blog_Title));
                cm.Parameters.Add(new SqlParameter("@blog_categories_name", item.blog_categories_name));
                cm.Parameters.Add(new SqlParameter("@blog_Decription", item.blog_Decription));


                cm.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();

            }
            return item;
        }


        public blogBO UpdateBlog(blogBO item)
        {
     

            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            con.Open();
            try
            {

                SqlCommand cm = new SqlCommand("UpdateBlog", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add(new SqlParameter("@blog_id", item.blog_id));
                cm.Parameters.Add(new SqlParameter("@blog_Title", item.blog_Title));
                cm.Parameters.Add(new SqlParameter("@blog_categories_name", item.blog_categories_name));
                cm.Parameters.Add(new SqlParameter("@blog_Decription", item.blog_Decription));


                cm.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();

            }
            return item;
        }

        public blogBO DeleteStuff(blogBO item)
        {

            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            con.Open();
            try
            {

                SqlCommand cm = new SqlCommand("DeleteStuff", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add(new SqlParameter("@blog_id", item.blog_id));
        

                cm.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();

            }
            return item;
        }
    }
}
