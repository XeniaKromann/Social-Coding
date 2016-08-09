﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestBruger : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (MySystem.User.IsUser())
        {
            lbl_user.Text = "Du er logget på!";
        }
        else
        {
            lbl_user.Text = "Du er IKKE logget på!";
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