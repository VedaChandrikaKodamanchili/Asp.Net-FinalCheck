using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.Cognizant.MovieCruiser.Dao;
using Com.Cognizant.MovieCruiser.Model;
using Com.Cognizant.MovieCruiser.Utility;


namespace Movie_Cruiser
{
    public partial class EditMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {

                    MovieDaoCollection.MovieListInitialization();
                    int id = Convert.ToInt32(Request.QueryString["id"].ToString());
                    Movie obj = (from x in MovieDaoCollection.movieList
                                 where x.Id == id
                                 select x).FirstOrDefault();
                    if (obj != null)
                    {
                        txtTitle.Text = obj.Title;
                        txtGross.Text = obj.BoxOffice.ToString();
                        if (obj.Active)
                        {
                            RadioBtnYes.Checked = true;
                        }
                        else
                        {
                            RadioBtnNo.Checked = true;
                        }
                        txtDateOfLaunch.Text = obj.DateOfLaunch.ToString();
                        txtGenre.SelectedValue = obj.Genre;
                        if (obj.HasTeaser)
                        {
                            HasTeaser.Checked = true;
                        }
                        else
                        {
                            HasTeaser.Checked = false;
                        }


                    }

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             MovieDaoCollection.MovieListInitialization();
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());

            Boolean active;
            Boolean hasTeaser;
            if (RadioBtnYes.Text == "Yes")
            {
                active = true;
            }
            else
            {
                active = false;
            }

            if (HasTeaser.Checked)
            {
                hasTeaser = true;
            }
            else
            {
                hasTeaser = false;
            }
            MovieDaoCollection.movieList.Where(w => w.Id == id).ToList().ForEach(i =>
            {
                i.Title = txtTitle.Text;
                i.BoxOffice = Convert.ToInt64(txtGross.Text);
                i.Active = active;
                i.DateOfLaunch = txtDateOfLaunch.Text;
                i.Genre = txtGenre.SelectedValue;
                i.HasTeaser = hasTeaser;
            });
            Response.Redirect("EditMovieStatus.aspx");
        }
    }
}