using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace back
{
    public partial class FormValidation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {

            string s = TextBox5.Text;

            char ch = s[0];

            if (ch > 'A' && ch <= 'Z')
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}