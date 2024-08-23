using AutoMapper;
using Core.Dtos;
using Core.Services;
using Data;
using Data.Entities;
using MainProject.Extensions;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using MainProject.Extensions;

namespace ShopMvcApp_PD211.Services
{
    public class FavoriteService : IFavoriteService
    {
        private readonly HttpContext httpContext;
        private readonly IMapper mapper;
        private readonly MoviesDbContext context;

        public FavoriteService(IHttpContextAccessor contextAccessor, IMapper mapper, MoviesDbContext context)
        {
            httpContext = contextAccessor.HttpContext!;
            this.mapper = mapper;
            this.context = context;
        }

        public List<MovieDto> GetProducts()
        {
            var ids = httpContext.Session.Get<List<int>>("cart_items") ?? new();

            var products = context.Movie.Include(x => x.FilmGenres).Where(x => ids.Contains(x.Id)).ToList();

            return mapper.Map<List<MovieDto>>(products);
        }

        public List<Movie> GetProductsEntity()
        {
            var ids = httpContext.Session.Get<List<int>>("cart_items") ?? new();

            return context.Movie.Include(x => x.FilmGenres).Where(x => ids.Contains(x.Id)).ToList();
        }

        public int GetCount()
        {
            // зчитуємо наявні елементи в корзині
            var ids = httpContext.Session.Get<List<int>>("cart_items");

            // якщо елементів немає, тоді створюємо порожній список
            if (ids == null) return 0;

            return ids.Count;
        }

        public void Add(int id)
        {
            // зчитуємо наявні елементи в корзині
            var ids = httpContext.Session.Get<List<int>>("cart_items");

            // якщо елементів немає, тоді створюємо порожній список
            if (ids == null) ids = new();
            // додаємо новий елемент
            ids.Add(id);

            // зберігаємо оновлений список корзини в cookies
            httpContext.Session.Set("cart_items", ids);
        }

        public void Remove(int id)
        {
            // зчитуємо наявні елементи в корзині
            var ids = httpContext.Session.Get<List<int>>("cart_items");

            // якщо елементів немає, тоді створюємо порожній список
            if (ids == null) return; // TODO: throw exception

            // додаємо новий елемент
            ids.Remove(id);

            // зберігаємо оновлений список корзини в cookies
            httpContext.Session.Set("cart_items", ids);
        }

        public void Clear()
        {
            httpContext.Session.Remove("cart_items");
        }

        public List<Movie> GetMoviesEntity()
        {
            var ids = httpContext.Session.Get<List<int>>("cart_items") ?? new();

            return context.Movie.Include(x => x.FilmGenres).Where(x => ids.Contains(x.Id)).ToList();
        }
    }
}