using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCompositionRoot.MyTypes
{
    public class MovieManager : IMovieManager
    {
        public IReadOnlyList<Movie> GetMovies()
        {
            return Array.Empty<Movie>();
        }
    }
}
