using MediatR;
using Movies.API.DTOs;
using Movies.API.Repositories;

namespace Movies.API.Commands.MovieCreate
{
    public class MovieInsertCommandHandler : IRequestHandler<MovieInsertCommand,ResponseDto<int>>
    {
        private readonly IMovieRepository _movieRepository;

        public MovieInsertCommandHandler(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }


        public Task<ResponseDto<int>> Handle(MovieInsertCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
