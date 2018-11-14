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
        public List<Monster> mList = new List<Monster>();

        protected void Page_Load(object sender, EventArgs e)
        {

            generateMonsters();


        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            generateMonsters();
        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("asda");
            foreach(var m in mList)
            {
                System.Diagnostics.Debug.WriteLine(m);
            }


        }

        protected void lstBoxMonsters_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {


                //aLWAYS returns index '0'

                System.Diagnostics.Debug.WriteLine("asd");
                displayMonsterDetails();
                //    txtMonsterName.Text = mList[lstBoxMonsters.SelectedIndex].name;
                System.Diagnostics.Debug.WriteLine(lstBoxMonsters.SelectedIndex);
                System.Diagnostics.Debug.WriteLine(mList[lstBoxMonsters.SelectedIndex + 2].name);
                displayMonsterInfo();
            }


        }

        public void displayMonsterInfo()
        {
            txtMonsterName.Text = mList[lstBoxMonsters.SelectedIndex + 1].name;
            txtMonsterChallengeRating.Text = mList[lstBoxMonsters.SelectedIndex + 1].challenge_rating;
            txtMonsterHitDice.Text = mList[lstBoxMonsters.SelectedIndex + 1].hit_dice;
            txtMonsterHitPoints.Text = mList[lstBoxMonsters.SelectedIndex + 1].hit_points;
            txtMonsterType.Text = mList[lstBoxMonsters.SelectedIndex + 1].type;
            txtMonsterAlignment.Text = mList[lstBoxMonsters.SelectedIndex + 1].alignment;
        }

        public void generateMonsters()
        {


            lstBoxMonsters.Items.Clear();
            System.Diagnostics.Debug.WriteLine("trivia boy");
            try
            {

                mList.Clear();
                var json = new WebClient().DownloadString("https://dl.dropboxusercontent.com/s/iwz112i0bxp2n4a/5e-SRD-Monsters.json");  //NOTE FIX THIS this needs to be got on page load
                //then use mList to shorten searched results to that list
                //same way you did filtering search results on your dissertation

                JavaScriptSerializer js = new JavaScriptSerializer();

                List<Monster> listMonster = js.Deserialize<List<Monster>>(json);

                string search = txtSearch.Text.ToLower();
                int i = 0;
                    
                foreach (var m in listMonster)
                {

                    if (search == "" && txtChallengeRating.Text != "" && txtType.SelectedValue == "")           //ftf
                    {
                        if (m.challenge_rating == txtChallengeRating.Text)
                        {
                            lstBoxMonsters.Items.Add(m.name);
                           

                            mList.Add(m);
                            System.Diagnostics.Debug.WriteLine("yeet " + mList[i].name);
                            i++;
                        }
                    }
                    else if (search == "" && txtChallengeRating.Text == "" && txtType.SelectedValue != "")      // fft                  // ttt ttf tff fff
                    {                                                                                                                   //tft ftf
                        if (m.type == txtType.SelectedValue.ToLower())
                        {
                            lstBoxMonsters.Items.Add(m.name);
                            mList.Add(m);
                            System.Diagnostics.Debug.WriteLine("yeet " + mList[i].name);
                            i++;
                        }
                    }
                    else if (search == "" && txtChallengeRating.Text != "" && txtType.SelectedValue != "")       //ftt
                    {
                        if (m.type == txtType.SelectedValue.ToLower() && m.challenge_rating == txtChallengeRating.Text)
                        {
                            lstBoxMonsters.Items.Add(m.name);
                            mList.Add(m);
                            System.Diagnostics.Debug.WriteLine("yeet " + mList[i].name);
                            i++;
                        }
                    }
                    else if (search != "" && txtChallengeRating.Text != "" && txtType.SelectedValue != "")      //ttt
                    {
                        if (m.type == txtType.SelectedValue.ToLower() && m.challenge_rating == txtChallengeRating.Text && m.name.ToLower().Contains(search))
                        {
                            lstBoxMonsters.Items.Add(m.name);

                            mList.Add(m);
                            System.Diagnostics.Debug.WriteLine("yeet " + mList[i].name);
                            i++;
                        }
                    }
                    else if (search != "" && txtChallengeRating.Text != "" && txtType.SelectedValue == "")      //ttf
                    {
                        {
                            if (m.challenge_rating == txtChallengeRating.Text && m.name.ToLower().Contains(search))
                            {
                                lstBoxMonsters.Items.Add(m.name);

                                mList.Add(m);
                                System.Diagnostics.Debug.WriteLine("yeet " + mList[i].name);
                                i++;

                            }
                        }
                    }
                    else if (search != "" && txtChallengeRating.Text == "" && txtType.SelectedValue != "")      //tft
                    {
                        {
                            if (m.type == txtType.SelectedValue.ToLower() && m.name.ToLower().Contains(search))
                            {
                                lstBoxMonsters.Items.Add(m.name);

                                mList.Add(m);
                                System.Diagnostics.Debug.WriteLine("yeet " + mList[i].name);
                                i++;
                            }
                        }
                    }
                    else if (search != "" && txtChallengeRating.Text == "" && txtType.SelectedValue == "")      //tff
                    {
                        if (m.name.ToLower().Contains(search))
                        {
                            lstBoxMonsters.Items.Add(m.name);

                            mList.Add(m);
                            System.Diagnostics.Debug.WriteLine("yeet " + mList[i].name);
                            i++;
                        }
                    }
                    else
                    {
                        lstBoxMonsters.Items.Add(m.name);
                       
                        mList.Add(m);
                        System.Diagnostics.Debug.WriteLine("yeet " + mList[i].name);
                        i++;

                    }


                }

            }

            catch (Exception)
            {
                System.Diagnostics.Debug.WriteLine("Error instanciating json variable");

                throw;
            }



        }

        public void displayMonsterDetails()
        {
            
        }

        protected void txtMonsterType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}