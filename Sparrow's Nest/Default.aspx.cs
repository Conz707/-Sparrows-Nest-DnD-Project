using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Web.Script.Serialization;
using Sparrows_Nest.helpers;
using System.Reflection;


namespace Sparrow_s_Nest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("trivia boy");
            try
            {


                

                var json = new WebClient().DownloadString("https://dl.dropboxusercontent.com/s/iwz112i0bxp2n4a/5e-SRD-Monsters.json");

                JavaScriptSerializer js = new JavaScriptSerializer();
                List<Monster> listMonster = js.Deserialize<List<Monster>>(json);

                var i = -1;
                foreach(var m in listMonster)
                {
                    i++;
                    System.Diagnostics.Debug.WriteLine(listMonster[i].senses);
                }
                

            }
            catch (Exception)
            {
                System.Diagnostics.Debug.WriteLine("Error instanciating json variable");
                
                throw;
            }

        }
    }
}