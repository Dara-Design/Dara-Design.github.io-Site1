using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Products : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        loadAllData();
    }

    private void loadAllData()
    {

        List<Product> products = Product.FetchAllProducts();
        foreach (Product product in products)
        {
            HtmlGenericControl singleProductContainer = new HtmlGenericControl();
            singleProductContainer.TagName = "div";
            singleProductContainer.Attributes["class"] = "singleProductContainer";

            Image profileImg = new Image();

            profileImg.ImageUrl = "~/imgs/" + product.Id + ".jpg";



            HtmlGenericControl infoProductContainer = new HtmlGenericControl();
            infoProductContainer.TagName = "div";
            infoProductContainer.Attributes["class"] = "infoProductContainer";

            Label name = new Label();
            name.CssClass = "productName";
            name.Text = product.ProductName + ", Kategorija proizvoda:" + product.ProductCategory;

            Label description = new Label();
            description.CssClass = "productDescription";
            description.Text = product.ProductDescription;

            LinkButton editButton = null;
            LinkButton deleteButton = null;
            if (Request.IsAuthenticated)
            {

                editButton = new LinkButton();
                editButton.ID = "editLink" + product.Id;
                editButton.Text = "Edit";
                editButton.Attributes["style"] = "margin-right:5px";
                editButton.PostBackUrl = "product.aspx?mode=edit&id=" + product.Id;

                deleteButton = new LinkButton();
                deleteButton.ID = "deleteLink" + product.Id;
                deleteButton.Text = "Delete";
                deleteButton.CommandArgument = product.Id.ToString();
                deleteButton.Click += DeleteButton_Click;

            }




            singleProductContainer.Controls.Add(profileImg);
            infoProductContainer.Controls.Add(name);
            if (Request.IsAuthenticated)
            {
                infoProductContainer.Controls.Add(editButton);
                infoProductContainer.Controls.Add(deleteButton);
            }
            singleProductContainer.Controls.Add(description);
            singleProductContainer.Controls.Add(infoProductContainer);

            ProductContainer.Controls.Add(singleProductContainer);
        }

    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        LinkButton source = (LinkButton)sender;
        int rows = Product.DeleteProductById(Convert.ToInt32(source.CommandArgument));

        if (rows == 1)
        {
            ProductContainer.Controls.Clear();
            loadAllData();
        }
    }
}