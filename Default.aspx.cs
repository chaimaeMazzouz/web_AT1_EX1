using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AT1_EX1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            if (nom.Text == "Mazzouz" && motPass.Text == "123")
            {
                resultat.Text = "Bienvenue chez Chaimae";
                resultat.ForeColor = Color.Green;
            }
            else
            {
                resultat.Text = "Login ou mot de pass incorrect";
                resultat.ForeColor = Color.Red;
            }
        }
    }
}