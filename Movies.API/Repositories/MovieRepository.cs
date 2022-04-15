using System.Data;
using Dapper;
using Movies.API.Commands.MovieCreate;
using Movies.API.Commands.MovieDelete;
using Movies.API.Commands.MovieUpdate;
using Movies.API.Models;

namespace Movies.API.Repositories;

public class MovieRepository : IMovieRepository
{
    private readonly IDbConnection _connection;

    public MovieRepository(IDbConnection connection)
    {
        _connection = connection;
    }

    public async Task<List<Movie>> GetAll()
    {
        var query = "select * from movies";
        var movies = await _connection.QueryAsync<Movie>(query);
        return movies.ToList();
    }

    public async Task<List<Movie>> GetAllWithPage(int page, int pageSize)
    {
        int offset = pageSize * (page - 1);
        var query = "select * from movies order by id desc limit @pagesize offset @offset";
        var movies = await _connection.QueryAsync<Movie>(query, new { pageSize = pageSize, offset = offset });
        return movies.ToList();
    }

    public async Task<Movie> GetById(int id)
    {
        var query = "select * from movies where id = @id";
        var movie = await _connection.QueryFirstOrDefaultAsync<Movie>(query, new {id = id});
        return movie;
    }


    public async Task<int> Save(MovieInsertCommand movieInsertCommand)
    {
        var command =
            "insert into movies(Title,Director,Ranking,Duration) values(@Title,@Director,@Ranking,@Duration) returning id";
        var id = await _connection.ExecuteScalarAsync<int>(command, movieInsertCommand.Movie);
        return id;
    }

    public async Task<bool> Update(MovieUpdateCommand movieUpdateCommand)
    {
        var command =
            "update movies set Title=@Title, Director=@Director, Ranking=@Ranking, Duration=@Duration where Id=@Id";
        return await _connection.ExecuteAsync(command, movieUpdateCommand.Movie) > 0;
    }

    public async Task<bool> Delete(MovieDeleteCommand movieDeleteCommand)
    {
        var command = "delete from movies where Id=@Id";
        return await _connection.ExecuteAsync(command, movieDeleteCommand) > 0;
    }
}
