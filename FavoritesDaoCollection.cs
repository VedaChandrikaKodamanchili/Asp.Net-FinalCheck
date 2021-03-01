﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.MovieCruiser.Model;
using Com.Cognizant.MovieCruiser.Utility;

namespace Com.Cognizant.MovieCruiser.Dao
{
    public class FavoritesDaoCollection : IFavoritesDao
    {
        public static List<Movie> favoritesMovieList = null;

        MovieDaoCollection movieDao = new MovieDaoCollection();
        public static void FavoritesListInitialization()
        { 
            if (favoritesMovieList == null)
            {
                favoritesMovieList = new List<Movie>()
                {

                    new Movie()
                    {
                        Id = 1,
                        Title = "Avatar",
                        BoxOffice = 2787965087,
                        Active = true,
                        DateOfLaunch = "15/03/2017",
                        Genre = "Science Fiction",
                        HasTeaser = true
                    },

                    new Movie()
                    {
                        Id = 2,
                        Title = "The Avengers",
                        BoxOffice = 1518812988,
                        Active = true,
                        DateOfLaunch = "23/12/2017",
                        Genre = "Superhero",
                        HasTeaser = false
                    },

                    new Movie()
                    {
                        Id = 3,
                        Title = "Titanic",
                        BoxOffice = 2187463944,
                        Active = true,
                        DateOfLaunch = "21/08/2017",
                        Genre = "Romance",
                        HasTeaser = false
                    }
                };
            }
        }
        public void AddMovieToFavorites(long userId, long movieId)
        {
            MovieDaoCollection movieDao = new MovieDaoCollection();
            List<Movie> movieList = movieDao.GetMovieListCustomer();
            Movie movie = (from temp in movieList
                           where temp.Id == movieId
                           select temp).FirstOrDefault();
            if (!favoritesMovieList.Contains(movie))
            {
                if (movie != null)
                {
                    int id = favoritesMovieList.Count() - 1;
                    favoritesMovieList.Insert(id, movie);
                    Console.WriteLine("Movie is added to favorites successfully");
                }
            }
            else
                Console.WriteLine("Movie is already in favorites");

        }

       

        public void GetAllFavorites(long userId)
        {
            Console.WriteLine("Favorites:");
            Console.WriteLine("ID  Title               Box Office($)    Genre");
            for (int i = 0; i < favoritesMovieList.Count(); i++)
            {
                Console.WriteLine("{0}   {1,-18}  {2,-13}    {3}", favoritesMovieList[i].Id, favoritesMovieList[i].Title, favoritesMovieList[i].BoxOffice, favoritesMovieList[i].Genre);
            }
            Console.WriteLine("No. of Favorites: " + favoritesMovieList.Count());
        }

        

        public void RemoveFavoriteItem(long userId, long movieId)
        {
            foreach (Movie movie in favoritesMovieList)
            {
                if (movie.Id == movieId)
                {
                    int i = (int)movieId - 1;
                    favoritesMovieList.Remove(favoritesMovieList[i]);
                    //Console.WriteLine("Movie removed from favorites successfully");
                }
            }
        }
        
    }
}
