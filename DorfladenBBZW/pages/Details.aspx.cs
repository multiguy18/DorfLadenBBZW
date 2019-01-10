using DorfladenBBZW.Models;
using DorfladenBBZW.Persistency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DorfladenBBZW.pages
{
    public partial class Details : System.Web.UI.Page
    {
        public Product CurrentProduct { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ProductsPersistency prodPersis = new ProductsPersistency();

            string idParam = Request.Params.Get("id");
            if (!string.IsNullOrEmpty(idParam))
            {
                CurrentProduct = prodPersis.GetById(idParam);
                productImage.ImageUrl = "~/img/" + CurrentProduct.ImageName;
                productName.Text = CurrentProduct.Name;
            }
        }

    }
}