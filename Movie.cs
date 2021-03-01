using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.MovieCruiser.Model
{
    public class Movie
    {

        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
               id = value;
            }
        }
        private string title;



        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        private long boxOffice;
        public long BoxOffice
        {
            get
            {
                return boxOffice;
            }
            set
            {
                boxOffice = value;
            }
        }
        private bool active;
        public bool Active
        {
            get
            {
                return active;
            }
            set
            {
                active = value;
            }
        }
        private string dateOfLaunch;
        public string DateOfLaunch
        {
            get
            {
                return dateOfLaunch;
            }
            set
            {
                dateOfLaunch = value;
            }
        }
        private string genre;
        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }
        private bool hasTeaser;
        public bool HasTeaser
        {
            get
            {
                return hasTeaser;
            }
            set
            {
                hasTeaser = value;
            }
        }
        public Movie()
        {

        }

        public Movie(int id, string title, long boxOffice, bool active, string dateOfLaunch, string genre, bool hasTeaser)
        {
            this.id = id;
            this.title = title;
            this.boxOffice = boxOffice;
            this.active = active;
            this.dateOfLaunch = dateOfLaunch;
            this.genre = genre;
            this.hasTeaser = hasTeaser;

        }
    }
}
