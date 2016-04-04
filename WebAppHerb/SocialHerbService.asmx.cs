using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using WebAppHerb.Models;
using System.Configuration;

namespace WebAppHerb
{
    /// <summary>
    /// Summary description for SocialHerbService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SocialHerbService : System.Web.Services.WebService
    {
        
        [WebMethod]
        public string Test(string nameHerb)
        {
            ServiceHerb sh = new ServiceHerb();
            return sh.Test(nameHerb);
        }
    }
}
