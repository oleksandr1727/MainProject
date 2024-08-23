using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Data;
using Data.Entities;
using AutoMapper;

namespace MainProject.Controllers
{
    public class FilmsController : Controller
    {
        private readonly IMapper mapper;
        private readonly MoviesDbContext context;

        public FilmsController(IMapper mapper, MoviesDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }

     

        public IActionResult Index()
        {
            // ... load data from database ...
            var products = context.Movie
                .Include(x => x.FilmGenres) // LEFT JOIN
                .ToList();

            return View(products);
        }

        // GET - open create page
        [HttpGet]
        public IActionResult Create()
        {
            LoadCategories();
            return View("Upser");
        }

        // POST - create object in db
        [HttpPost]
        public IActionResult Create(Movie model)
        {
            if (!ModelState.IsValid)
            {
                LoadCategories();
                return View("Upser", model);
            }

            context.Movie.Add(model);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = context.Movie.Find(id);

            if (product == null) return NotFound();

            LoadCategories();
            return View("Upser", product);
        }

        [HttpPost]
        public IActionResult Edit(Movie model)
        {
            if (!ModelState.IsValid)
            {
                LoadCategories();
                return View("Upser", model);
            }

            context.Movie.Update(model);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var product = context.Movie.Find(id);

            if (product == null) return NotFound(); // 404

            context.Movie.Remove(product);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        private void LoadCategories()
        {
            // ViewBag - collection of properties that is accessible in View
            ViewBag.Categories = new SelectList(context.FilmGenres.ToList(), "Id", "Name");
        }
    }
}
