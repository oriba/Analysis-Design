using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using DAL;

namespace PL
{
    public partial class HomePage : System.Web.UI.Page
    {
        private IBL itsBL;
        private IDAL itsDal;

        protected void Page_Load(object sender, EventArgs e)
        {
            itsBL = new CBL();
            itsDal = new CDAL();
            
        }

        protected void Home_Click(object sender, EventArgs e)
        {
            Label1.Text = "dkdjd";
            
        }

        protected void Food_Click(object sender, EventArgs e)
        {
            
        }

        protected void Entertainment_Click(object sender, EventArgs e)
        {

        }

        protected void HealthAndBeauty_Click(object sender, EventArgs e)
        {

        }

        protected void Apparel_Click(object sender, EventArgs e)
        {

        }

        protected void Electronics_Click(object sender, EventArgs e)
        {

        }

    }
}