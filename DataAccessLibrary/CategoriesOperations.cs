using Microsoft.Data.SqlClient;

using System.ComponentModel;

namespace DataAccessLibrary

{

    public class CategoriesOperations

    {

        static string connectionString =

            "server=mazenet-test;"+

           "Integrated Security=True;" +

            "Database=northwind;TrustServerCertificate=true";

        public List<Category> ShowAll()

        {

            List<Category> categories = new List<Category>();

            SqlConnection cn = null;

            SqlCommand cmd = null;

            try

            {

                cn = new SqlConnection(connectionString);

                cmd = new SqlCommand(" select categoryid,categoryname, description from categories", cn);

                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null)

                {

                    while (dr.Read())

                    {

                        Category category = new Category();
                        category.CatID = Convert.ToInt32(dr["categoryid"]);
                        category.Name = dr["categoryname"].ToString();

                        category.Description = dr["description"].ToString();

                        categories.Add(category);

                    }

                }

            }

            catch (Exception ex)

            {

                throw ex;

            }

            finally

            {

                cn.Close();

                cn.Dispose();

            }

            return categories;

        }

        public void NewCategory(Category category)

        {

        }

        public void DeleteCategory(int id)

        {

        }

        public void UpdateCategory(int id, Category newDetails)

        {

        }

    //    public Category SearchCategory(string name)

    //    {

    //    }

    //    public Category SearchCategory(int id)

    //    {

    //    }

    }

}

