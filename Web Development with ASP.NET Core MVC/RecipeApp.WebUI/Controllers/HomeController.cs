using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeApp.WebUI.Models;

namespace RecipeApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(RecipeRepository.Recipes);
        }

        public IActionResult Details(int id)
        {
            return View(RecipeRepository.Recipes.FirstOrDefault(f => f.Id == id));
        }

        public IActionResult Edit(int id)
        {
            return View(RecipeRepository.Recipes.FirstOrDefault(f => f.Id == id));
        }

        public IActionResult Delete(int id)
        {
            return View(RecipeRepository.Recipes.FirstOrDefault(f => f.Id == id));
        }
        public IActionResult Search()
        {
            return View(RecipeRepository.Recipes);
        }

        public IActionResult UpdateRecipe(int id, string name, string ingredients, string description, string tipsAndTricks, string time, string diff, int numberOfLikes) {

            Recipe x = RecipeRepository.GetById(id);
            x.Name = name;
            x.ingredients = ingredients;
            x.Description = description;
            x.tipsAndTricks = tipsAndTricks;
            x.time = time;
            x.difficulty = diff;
            x.numberOfLikes = numberOfLikes;

            return View(RecipeRepository.Recipes.FirstOrDefault(f => f.Id == id));

        }

    }
}