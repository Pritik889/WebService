using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using myserviceclassnameSpace;

public partial class _Default : System.Web.UI.Page
{
    /// <summary>
    /// Here i have create the instanse of service class and
    /// accsess method .
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        myserviceclassnameSpace.Service s = new Service();
       string sd= s.MyServiceMethod();
       Response.Write(sd);
    }
}