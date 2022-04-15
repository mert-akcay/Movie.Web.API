using Movies.API.Commands.MovieCreate;
using Movies.API.Commands.MovieDelete;
using Movies.API.Commands.MovieUpdate;
using Movies.API.Models;

namespace Movies.API.Repositories;

public interface IMovieRepository
{
    Task<List<Movie>> GetAll();
    Task<List<Movie>> GetAllWithPage(int page, int pageSize);
    Task<Movie> GetById(int id);
    Task<int> Save(MovieInsertCommand movieInsertCommand);
    Task<bool> Update(MovieUpdateCommand movieUpdateCommand);
    Task<bool> Delete(MovieDeleteCommand movieDeleteCommand);

}