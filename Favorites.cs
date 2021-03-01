﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.MovieCruiser.Model
{
    class Favorites
    {
        private List<Movie> movieList;


        public List<Movie> MovieList
        {
            get { return movieList; }
            set { movieList = value; }
        }

        private double total;

        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        // Add constructors here
        public Favorites() { }


        public Favorites(List<Movie> movieList, double Total)
        {
            this.movieList =movieList;
            this.Total = total;
        }
    }
}
