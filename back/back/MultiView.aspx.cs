﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace back
{
    public partial class MultiView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 3;
            Label1.Text = TextBox1.Text;
            Label2.Text = TextBox2.Text;
            Label3.Text = TextBox3.Text;
            Label4.Text = TextBox4.Text;
            Label5.Text = TextBox5.Text;
            Label6.Text = TextBox6.Text;
            Label7.Text = TextBox7.Text;
            Label8.Text = TextBox8.Text;
            Label9.Text = TextBox9.Text;
            Label10.Text = TextBox10.Text;
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Student Register Successfully')</script>");
        }
    }
}