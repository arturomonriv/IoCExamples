using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCompositionRoot.MyTypes
{
    public class MovieManager : IMovieManager
    {
        private readonly IMovieRepository repository;

        public MovieManager(IMovieRepository repository)
        {
            this.repository = repository;
        }

        public IReadOnlyList<Movie> GetMovies()
        {
            return repository.GetList();
        }
    }
}
