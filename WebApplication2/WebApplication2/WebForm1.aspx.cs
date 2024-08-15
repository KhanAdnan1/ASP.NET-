using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TextBox1.Text) ||
                string.IsNullOrEmpty(TextBox2.Text) ||
                string.IsNullOrEmpty(TextBox3.Text) ||
                string.IsNullOrEmpty(DropDown1.SelectedValue) ||
                string.IsNullOrEmpty(TextBox4.Text))
            {
                Label6.Text = "*Please enter proper details";
            }
            else
            {
                Label1.Text = $"Emp Name is {TextBox1.Text}";
                Label2.Text = $"Emp Email is {TextBox2.Text}";
                Label3.Text = $"Emp ID is {TextBox3.Text}";
                Label4.Text = $"Emp Department is {DropDown1.SelectedValue}";
                Label5.Text = $"Emp Salary is {TextBox4.Text}";
            }
        }
    }
}