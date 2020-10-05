using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Product : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack)
            return;
        if (Request.QueryString["mode"] == null)
            return;
        if (Request.QueryString["mode"].Equals("new"))
        {
            PageHeading.InnerText = "New Product";

        }
        else if (Request.QueryString["mode"].Equals("edit"))
        {
            PageHeading.InnerText = "Edit Product";

            if (Request.QueryString["id"] != null)
            {
                Product product = Product.FetchProductById(Convert.ToInt32(Request.QueryString["id"]));

                ProductNameTextBox.Text = product.ProductName;
                ProductCategoryTextBox.Text = product.ProductCategory;
                ProductDescriptionTextArea.InnerText = product.ProductDescription;

                IdHiddenfield.Value = Request.QueryString["id"];
            }
        }


    }



    protected void SaveButton_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["mode"].Equals("edit"))
        {
            Product product = new Product();
            product.ProductName = ProductNameTextBox.Text;
            product.ProductCategory = ProductCategoryTextBox.Text;
            product.ProductDescription = ProductDescriptionTextArea.InnerText.ToString();

            product.Id = Convert.ToInt32(IdHiddenfield.Value);

            int rows = product.UpdateProduct();
            if (rows == 1)
            {
                Response.Redirect("products.aspx");
            }
            else
            {
                Response.Redirect("contact.aspx");
            }

        }


        else if (Request.QueryString["mode"].Equals("new"))
        {
            Product product = new Product();
            product.ProductName = ProductNameTextBox.Text;
            product.ProductCategory = ProductCategoryTextBox.Text;
            product.ProductDescription = ProductDescriptionTextArea.InnerText;


            int rows = product.InsertProduct();

            if (rows == 1)
            {
                Response.Redirect("products.aspx");
            }
            else
            {
                Response.Redirect("contact.aspx");
            }

        }

    }
}