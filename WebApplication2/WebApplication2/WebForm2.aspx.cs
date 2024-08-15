using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //
        }
        protected void Drop_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(TextBox1.Text);
            b=int.Parse(TextBox2.Text);
            string sign = DropList1.SelectedValue;

            if (sign.Equals("+"))
            {
                Label1.Text = $"Addition of {a} and {b} is {a + b}";
            }
            else if (sign.Equals("-"))
            {
                Label1.Text = $"Subtraction  of {a} and {b} is {a - b}";
            }
            else if (sign.Equals("*"))
            {
                Label1.Text = $"Multiplication {a} and {b} is {a * b}";
            }
            else if (sign.Equals("/")) 
            {
                Label1.Text = $"Divisionof {a} and {b} is {a / b}";
            }
            else
            {
                Label1.Text = "Please enter a proper details";
            }
        }
    }
}