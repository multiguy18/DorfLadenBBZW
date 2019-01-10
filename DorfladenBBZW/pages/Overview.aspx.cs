using DorfladenBBZW.Models;
using DorfladenBBZW.Persistency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorfladenBBZW.TypeExtensions;

namespace DorfladenBBZW.Pages
{
    public partial class Overview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductsPersistency prodPersis = new ProductsPersistency();
            IReadOnlyCollection<Product> products = prodPersis.GetAll();

            overviewContent.DataSource = products;
            overviewContent.DataBind();
        }
    }
}