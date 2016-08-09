using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestBruger : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (mysystem.user.isuser())
        {
            lbl_user.text = "du er logget på!";
        }
        else
        {
            lbl_user.text = "du er ikke logget på!";
        }

    }
    protected void btn_opret_Click(object sender, EventArgs e)
    {
        MySystem.User.CreateSession();

    }
    protected void btn_slet_Click(object sender, EventArgs e)
    {
        MySystem.User.RemoveSession();
    }
}