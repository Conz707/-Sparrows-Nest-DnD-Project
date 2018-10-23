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
using System.Windows;

namespace Sparrows_Nest
{
    public partial class MonsterGen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            System.Diagnostics.Debug.WriteLine("trivia boy");
            try
            {




                var json = new WebClient().DownloadString("https://dl.dropboxusercontent.com/s/iwz112i0bxp2n4a/5e-SRD-Monsters.json");

                JavaScriptSerializer js = new JavaScriptSerializer();
                List<Monster> listMonster = js.Deserialize<List<Monster>>(json);


                string search = txtSearch.Text.ToLower();

                foreach (var m in listMonster)
                {

                    if (search == "" && txtChallengeRating.Text != "" && txtType.SelectedValue == "")           //ftf
                    {
                        if (m.challenge_rating == txtChallengeRating.Text)
                        {
                            ListBox1.Items.Add(m.name);
                        }
                    }
                    else if (search == "" && txtChallengeRating.Text == "" && txtType.SelectedValue != "")      // fft                  // ttt ttf tff fff
                    {                                                                                                                   //tft ftf
                        if (m.type == txtType.SelectedValue.ToLower())
                        {
                            ListBox1.Items.Add(m.name);
                        }
                    }
                    else if (search == "" && txtChallengeRating.Text != "" && txtType.SelectedValue != "")       //ftt
                    {
                        if (m.type == txtType.SelectedValue.ToLower() && m.challenge_rating == txtChallengeRating.Text)
                        {
                            ListBox1.Items.Add(m.name);
                        }
                    }
                    else if (search != "" && txtChallengeRating.Text != "" && txtType.SelectedValue != "")      //ttt
                    {
                        if (m.type == txtType.SelectedValue.ToLower() && m.challenge_rating == txtChallengeRating.Text && m.name.ToLower().Contains(search))
                        {
                            ListBox1.Items.Add(m.name);
                        }
                    }
                    else if (search != "" && txtChallengeRating.Text != "" && txtType.SelectedValue == "")      //ttf
                    {
                        {
                            if (m.challenge_rating == txtChallengeRating.Text && m.name.ToLower().Contains(search))
                            {
                                ListBox1.Items.Add(m.name);
                            }
                        }
                    }
                    else if (search != "" && txtChallengeRating.Text == "" && txtType.SelectedValue != "")      //tft
                    {
                        {
                            if (m.type == txtType.SelectedValue.ToLower() && m.name.ToLower().Contains(search))
                            {
                                ListBox1.Items.Add(m.name);
                            }
                        }
                    }
                    else if (search != "" && txtChallengeRating.Text == "" && txtType.SelectedValue == "")      //tff
                    {
                        if (m.name.ToLower().Contains(search))
                        {
                            ListBox1.Items.Add(m.name);
                        }
                    }

                    else
                    {
                        ListBox1.Items.Add(m.name);
                    }
                }
            }
            
            catch (Exception)
            {
                System.Diagnostics.Debug.WriteLine("Error instanciating json variable");

                throw;
            }
            
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}