using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace back
{
    public partial class auto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sign=DropDownList1.SelectedValue;
            int a = int.Parse(TextBox1.Text);
            int b= int.Parse(TextBox2.Text);
            if (sign == "+")
            {
                Label1.Text = (a + b).ToString();
            }
            else if (sign == "-")
            {
                Label1.Text = (a - b).ToString();
            }
            else if (sign == "*")
            {
                Label1.Text = (a * b).ToString();
            }
            else if (sign == "/") 
            { 
                Label1.Text = (a / b).ToString();
            }

        }
    }
}