﻿using Microsoft.AspNetCore.Mvc;
using Fayroz.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Fayroz.ContextDbConfig;
using Microsoft.AspNetCore.Authorization;

namespace Fayroz.Controllers
{
    public class RecipeController : Controller
    {

        private readonly FayrozDbContext _dbContext;
        private readonly UserManager<User> _userManager;
        public RecipeController(FayrozDbContext dbContext, UserManager<User> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var recipesByCategory = _dbContext.Recipes
                .Include(r => r.Category)
                .AsEnumerable()
                .GroupBy(r => r.Category) 
                .ToList();
            List<Category> Categories = _dbContext.Categories.ToList();
            ViewBag.Categories = Categories;

            var AllRecipes = _dbContext.Recipes.ToArray();
            ViewBag.AllRecipes = AllRecipes;
            return View(recipesByCategory);
        }

        public IActionResult Search_Menu(string category)
        {
            var recipes = _dbContext.Recipes.Where(r => r.Category.Name.Contains(category)).ToList();
            ViewBag.Recipe = recipes;
            List<Category> Categories = _dbContext.Categories.ToList();
            ViewBag.Categories = Categories;
            return View("Search");
        }

        public IActionResult Search(string recipe)
        {
            var recipes = _dbContext.Recipes.Where(r => r.Name.Contains(recipe)).ToList();
            ViewBag.Recipe = recipes;
            List<Category> Categories = _dbContext.Categories.ToList();
            ViewBag.Categories = Categories;
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Order(int id) {
            Recipe order = _dbContext.Recipes.FirstOrDefault(x => x.Id == id);
            List<Category> Categories = _dbContext.Categories.ToList();
            ViewBag.Categories = Categories;
            var user = await _userManager.GetUserAsync(HttpContext.User);
            ViewBag.UserId = user.Id;
            ViewBag.Address = user.Address;
            return View(order);
        }
        [HttpPost]
        [Authorize]
        public IActionResult Order(Order order)
        {
            if(ModelState.IsValid)
            {
                order.Id = 0;
                _dbContext.Orders.Add(order);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Order","Recipe",order.RecipeId);
        }

        [HttpGet]
        public IActionResult GetRecipeNames(string term)
        {
            var recipeNames = _dbContext.Recipes
                .Where(r => r.Name.Contains(term))
                .Select(r => r.Name)
                .ToList();

            var recipeNamesString = string.Join(",", recipeNames);

            return Content(recipeNamesString);
        }
    }
}