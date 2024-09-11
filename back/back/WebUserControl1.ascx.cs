using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace back
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TextBox1.Text);
                string name = TextBox2.Text;
                string contact = TextBox3.Text;
                string email = TextBox4.Text;
                double salary = double.Parse(TextBox5.Text);


                Label1.Text = id.ToString();
                Label2.Text = name;
                Label3.Text = contact;
                Label4.Text = email;
                Label5.Text = salary.ToString();
            }
            catch(FormatException ex)
            {
                LabelError.Text ="Enter a valid details";
            }
          
            
        }
    }
}