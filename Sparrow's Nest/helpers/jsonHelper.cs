using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sparrows_Nest.helpers;
using System.Web.UI.WebControls;
using System.Net;
using System.Web.Script.Serialization;
using System.Reflection;
using System.Windows;

namespace Sparrows_Nest.helpers
{
    public class jsonHelper
    {

        static String json = new WebClient().DownloadString("https://dl.dropboxusercontent.com/s/iwz112i0bxp2n4a/5e-SRD-Monsters.json");
         
        static JavaScriptSerializer js = new JavaScriptSerializer();

        List<Monster> listMonster = js.Deserialize<List<Monster>>(json);
    }
}