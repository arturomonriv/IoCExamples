using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCompositionRoot.MyTypes
{
    public class MovieRepository : IMovieRepository
    {
        public IReadOnlyList<Movie> GetList()
        {
            Movie[] movies = new Movie[3];
            Movie movie = new Movie();
            movie.Id = 1;
            movie.Name = "Santos contra las momias";
            movies[0] = movie;

            movie = new Movie();
            movie.Id = 2;
            movie.Name = "Biruta y Capulina";
            movies[1] = movie;

            movie = new Movie();
            movie.Id = 3;
            movie.Name = "Chabelo y Pepito";
            movies[2] = movie;

            return movies;
        }
    }
}
