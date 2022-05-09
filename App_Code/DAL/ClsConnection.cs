using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using MobilePaymentSystem;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ClsConnection
/// </summary>
public class ClsConnection
{
	public ClsConnection()
	{

	}
    public static string Connectionstring
    {
        get
        {
            return (ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);
        }
    }
}
