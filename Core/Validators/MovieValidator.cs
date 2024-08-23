using FluentValidation;
using Core.Dtos;
using Data.Entities;

namespace Core.Validators
{
    public class ProductValidator : AbstractValidator<MovieDto>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.ImageUrl)
                .NotNull()
                .NotEmpty()
                .Must(ValidateUri).WithMessage("Image URL must be a valid address.");
            RuleFor(x => x.Lenght)
                .GreaterThan(0);
            RuleFor(x => x.Rating)
                .InclusiveBetween(1, 5);
            RuleFor(x => x.AdultRating)
               .InclusiveBetween(0, 21);
            RuleFor(x => x.FilmGenres)
                .NotNull()
                .NotEmpty();
        }

        public bool ValidateUri(string? uri)
        {
            // just so the validation passes if the uri is not required / nullable
            if (string.IsNullOrEmpty(uri))
            {
                return true;
            }
            return Uri.TryCreate(uri, UriKind.Absolute, out _);
        }
    }
}
