using System;
using System.Collections.Generic;
using System.Text;
using ExercicioDAOCRUD.PL;

namespace ExercicioDAOCRUD.BL
{
    interface IMovieCrud
    {
        List<Movie> GetMovies();
        Movie GetMovieById(int id);
        void PostMovie(Movie newMovie);
        void PutMovie(Movie toUpMovie);
        void DelMovie(int id);
    }
}
