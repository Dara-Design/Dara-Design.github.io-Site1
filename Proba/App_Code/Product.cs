using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// Summary description for Product
/// </summary>
public class Product
{
    
         private int id;

    private string productName;

    private string productCategory;

    private string productDescription;

    public int Id
    {
        get { return id; }
        set
        {
            id = value;
        }
    }

    public string ProductName
    {
        get { return productName; }
        set
        {
            productName = value;
        }
    }

    public string ProductCategory
    {
        get { return productCategory; }
        set
        {
            productCategory = value;
        }
    }

    public string ProductDescription
    {
        get { return productDescription; }
        set
        {
            productDescription = value;
        }
    }

    public Product()
    {

    }


    public static List<Product> FetchAllProducts()
    {
        List<Product> allProducts = new List<Product>();
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = WebConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        try
        {
            using (conn)
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT ProductId, Product_Name,Product_Category,Product_Description FROM Product WHERE Is_Deleted=0", conn);
                Product product = null;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        product = new Product();
                        product.Id = Convert.ToInt32(reader["ProductId"]);
                        product.ProductName = reader["Product_Name"].ToString();
                        product.ProductCategory = reader["Product_Category"].ToString();
                        product.ProductDescription = reader["Product_Description"].ToString();
                    

                        allProducts.Add(product);
                    }

                }
            }
        }
        catch
        {
            // to do
        }
        return allProducts;
    }

    public static int DeleteProductById(int productId)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = WebConfigurationManager.ConnectionStrings["Test"].ConnectionString;

        int rows = 0;
        try
        {

            using (conn)
            {
                conn.Open();
                SqlCommand command = new SqlCommand("UPDATE Product SET Is_Deleted = 1 WHERE ProductId=@Id", conn);
                SqlParameter myParam = new SqlParameter("@Id", System.Data.SqlDbType.Int, 11);
                myParam.Value = productId;

                command.Parameters.Add(myParam);
                rows = command.ExecuteNonQuery();
            }
        }
        catch
        {
            // to do
        }

        return rows;

    }

    public static Product FetchProductById(int id)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = WebConfigurationManager.ConnectionStrings["Test"].ConnectionString;

        Product product = null;

        try
        {

            using (conn)
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Product_Name,Product_Category,Product_Description FROM Product  WHERE ProductId=" + id, conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    product = new Product();

                    product.ProductName = reader["Product_Name"].ToString();
                    product.ProductCategory = reader["Product_Category"].ToString();
                    product.ProductDescription = reader["Product_Description"].ToString();

                   
                }
            }
        }
        catch
        {
            // to do
        }
        return product;
    }

    public int UpdateProduct()
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = WebConfigurationManager.ConnectionStrings["Test"].ConnectionString;

        int rows = 0;

        try
        {
            using (conn)
            {
                conn.Open();

                SqlCommand command = new SqlCommand("UPDATE Product SET Product_Name=@ProductName,Product_Category=@ProductCategory,Product_Description=@ProductDescription WHERE ProductId=@Id", conn);

                SqlParameter productNameParam = new SqlParameter("@ProductName", SqlDbType.NVarChar);
                productNameParam.Value = ProductName;

                SqlParameter productCategoryParam = new SqlParameter("@ProductCategory", SqlDbType.NVarChar);
                productCategoryParam.Value = ProductCategory;

                SqlParameter productDescriptionParam = new SqlParameter("@ProductDescription", SqlDbType.NVarChar);
                productDescriptionParam.Value = ProductDescription;


                SqlParameter myParam = new SqlParameter("Id", SqlDbType.Int, 11);
                myParam.Value = Id;

                command.Parameters.Add(productNameParam);
                command.Parameters.Add(productCategoryParam);
                command.Parameters.Add(productDescriptionParam);
                command.Parameters.Add(myParam);
                rows = command.ExecuteNonQuery();

            }


        }
        catch
        {
            // to do
        }
        return rows;
    }

    public int InsertProduct()
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = WebConfigurationManager.ConnectionStrings["Test"].ConnectionString;

        int rows = 0;
        try
        {
            using (conn)
            {
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Person(Product_Name,Product_Category,Product_Description,Is_Deleted) VALUES (@ProductName,@ProductCategory, @ProductDescription,0)", conn);

                SqlParameter productNameParam = new SqlParameter("@ProductName", SqlDbType.NVarChar);
                productNameParam.Value = ProductName;

                SqlParameter productCategoryParam = new SqlParameter("@ProductCategory", SqlDbType.NVarChar);
                productCategoryParam.Value = ProductCategory;

                SqlParameter productDescriptionParam = new SqlParameter("@ProductDescription", SqlDbType.NVarChar);
                productDescriptionParam.Value = ProductDescription;


                command.Parameters.Add(productNameParam);
                command.Parameters.Add(productCategoryParam);
                command.Parameters.Add(productDescriptionParam);


                rows = command.ExecuteNonQuery();
            }
        }
        catch (Exception err)
        {
            //to do
        }
        return rows;
    }
}