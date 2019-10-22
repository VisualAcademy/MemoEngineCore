using System;

namespace MemoEngineCore
{
    public partial class FrmHelloWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = txtInput.Text;
            txtInput.Text = String.Empty;
        }
    }
}
