using AutoMapper;
using Core.Dtos;
using Core.Services;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MainProject.Extensions;
using MainProject.Services;

namespace MainProject.Controllers
{
    public class FavoritesController : Controller
    {
        private readonly IFavoriteService favoriteService;

        public FavoritesController(IFavoriteService favoriteService)
        {
            this.favoriteService = favoriteService;
        }
        // відображає сторінку корзини із доданими продуктами
        public IActionResult Index()
        {
            return View(favoriteService.GetProducts());
        }

        // додає продукт в корзину
        public IActionResult Add(int id, string? returnUrl)
        {
            favoriteService.Add(id);
            return Redirect(returnUrl ?? "/");
        }

        // видаляє продукт з корзини
        public IActionResult Remove(int id)
        {
            favoriteService.Remove(id);
            return RedirectToAction("Index");
        }
    }
}