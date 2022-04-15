using FluentValidation;
using Movies.API.DTOs;

namespace Movies.API.Validators;

public class MovieRequestDtoValidator : AbstractValidator<MovieRequestDto>
{
    public MovieRequestDtoValidator()
    {
        RuleFor(x => x.Title).NotNull().WithMessage("Movie title cannot be null").NotEmpty()
            .WithMessage("Movie title cannot be empty");
        RuleFor(x => x.Director).NotNull().WithMessage("Movie Director cannot be null").NotEmpty()
            .WithMessage("Movie Director cannot be empty");
    }
}