using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCompositionRoot.MyTypes
{
    public interface IMovieManager
    {
        IReadOnlyList<Movie> GetMovies();
    }
}
