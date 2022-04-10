using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApp.WebUI.Models
{
    public static class RecipeRepository
    {

        private static List<Recipe> recipes = null;

        static RecipeRepository()
        {
            recipes = new List<Recipe>()
            {
                new Recipe(){Id                =1,Name="Vegemite on Toast",Description="First of all, toast a bread and butter it. Then after this, spread a fine layer of vegemite over it. After this, break an egg into every hollow, use tomato for topping Scatter the items like, chives, parmesan, salt as well as pepper all over, Then bake at THREE HUNDRED FIFTY (35o) degrees Fahrenheit for approximately 1/3 hour or till egg is set. Then take out of oven and allow to cool for FIVE min.",difficulty="Basic",time="30mins",numberOfLikes=5,ingredients="2 slices bread, preferable white 1 / 8 teaspoon vegemite, more if you are game 1 / 2 teaspoon butter or 1 / 2 teaspoon margarine",tipsAndTricks="Be patient."},
                new Recipe(){Id                =2,Name="Banana Nut Bread",Description="First of all, toast a bread and butter it. Then after this, spread a fine layer of vegemite over it. After this, break an egg into every hollow, use tomato for topping Scatter the items like, chives, parmesan, salt as well as pepper all over, Then bake at THREE HUNDRED FIFTY (35o) degrees Fahrenheit for approximately 1/3 hour or till egg is set. Then take out of oven and allow to cool for FIVE min.",difficulty="Basic",time="30mins",numberOfLikes=5,ingredients="2 slices bread, preferable white 1 / 8 teaspoon vegemite, more if you are game 1 / 2 teaspoon butter or 1 / 2 teaspoon margarine",tipsAndTricks="Be patient."},
                new Recipe(){Id                =3,Name="Breakfast on an English Muffin",Description="First of all, toast a bread and butter it. Then after this, spread a fine layer of vegemite over it. After this, break an egg into every hollow, use tomato for topping Scatter the items like, chives, parmesan, salt as well as pepper all over, Then bake at THREE HUNDRED FIFTY (35o) degrees Fahrenheit for approximately 1/3 hour or till egg is set. Then take out of oven and allow to cool for FIVE min.",difficulty="Basic",time="30mins",numberOfLikes=5,ingredients="2 slices bread, preferable white 1 / 8 teaspoon vegemite, more if you are game 1 / 2 teaspoon butter or 1 / 2 teaspoon margarine",tipsAndTricks="Be patient."},
                new Recipe(){Id                =4,Name="Cinnamon and Raisin Oats",Description="First of all, toast a bread and butter it. Then after this, spread a fine layer of vegemite over it. After this, break an egg into every hollow, use tomato for topping Scatter the items like, chives, parmesan, salt as well as pepper all over, Then bake at THREE HUNDRED FIFTY (35o) degrees Fahrenheit for approximately 1/3 hour or till egg is set. Then take out of oven and allow to cool for FIVE min.",difficulty="Basic",time="30mins",numberOfLikes=5,ingredients="2 slices bread, preferable white 1 / 8 teaspoon vegemite, more if you are game 1 / 2 teaspoon butter or 1 / 2 teaspoon margarine",tipsAndTricks="Be patient."},
                new Recipe(){Id                =5,Name="Lemonade Scones",Description="First of all, toast a bread and butter it. Then after this, spread a fine layer of vegemite over it. After this, break an egg into every hollow, use tomato for topping Scatter the items like, chives, parmesan, salt as well as pepper all over, Then bake at THREE HUNDRED FIFTY (35o) degrees Fahrenheit for approximately 1/3 hour or till egg is set. Then take out of oven and allow to cool for FIVE min.",difficulty="Basic",time="30mins",numberOfLikes=5,ingredients="2 slices bread, preferable white 1 / 8 teaspoon vegemite, more if you are game 1 / 2 teaspoon butter or 1 / 2 teaspoon margarine",tipsAndTricks="Be patient."},
                new Recipe(){Id                =6,Name="Asparagus Omelette Wraps",Description="First of all, toast a bread and butter it. Then after this, spread a fine layer of vegemite over it. After this, break an egg into every hollow, use tomato for topping Scatter the items like, chives, parmesan, salt as well as pepper all over, Then bake at THREE HUNDRED FIFTY (35o) degrees Fahrenheit for approximately 1/3 hour or till egg is set. Then take out of oven and allow to cool for FIVE min.",difficulty="Basic",time="30mins",numberOfLikes=5,ingredients="2 slices bread, preferable white 1 / 8 teaspoon vegemite, more if you are game 1 / 2 teaspoon butter or 1 / 2 teaspoon margarine",tipsAndTricks="Be patient."},
                new Recipe(){Id                =7,Name="Chicken Stew",Description="First of all, toast a bread and butter it. Then after this, spread a fine layer of vegemite over it. After this, break an egg into every hollow, use tomato for topping Scatter the items like, chives, parmesan, salt as well as pepper all over, Then bake at THREE HUNDRED FIFTY (35o) degrees Fahrenheit for approximately 1/3 hour or till egg is set. Then take out of oven and allow to cool for FIVE min.",difficulty="Basic",time="30mins",numberOfLikes=5,ingredients="2 slices bread, preferable white 1 / 8 teaspoon vegemite, more if you are game 1 / 2 teaspoon butter or 1 / 2 teaspoon margarine",tipsAndTricks="Be patient."},
                new Recipe(){Id                =8,Name="Chicken Stew",Description="First of all, toast a bread and butter it. Then after this, spread a fine layer of vegemite over it. After this, break an egg into every hollow, use tomato for topping Scatter the items like, chives, parmesan, salt as well as pepper all over, Then bake at THREE HUNDRED FIFTY (35o) degrees Fahrenheit for approximately 1/3 hour or till egg is set. Then take out of oven and allow to cool for FIVE min.",difficulty="Basic",time="30mins",numberOfLikes=5,ingredients="2 slices bread, preferable white 1 / 8 teaspoon vegemite, more if you are game 1 / 2 teaspoon butter or 1 / 2 teaspoon margarine",tipsAndTricks="Be patient."},
                new Recipe(){Id                =9,Name="Chicken Stew",Description="First of all, toast a bread and butter it. Then after this, spread a fine layer of vegemite over it. After this, break an egg into every hollow, use tomato for topping Scatter the items like, chives, parmesan, salt as well as pepper all over, Then bake at THREE HUNDRED FIFTY (35o) degrees Fahrenheit for approximately 1/3 hour or till egg is set. Then take out of oven and allow to cool for FIVE min.",difficulty="Basic",time="30mins",numberOfLikes=5,ingredients="2 slices bread, preferable white 1 / 8 teaspoon vegemite, more if you are game 1 / 2 teaspoon butter or 1 / 2 teaspoon margarine",tipsAndTricks="Be patient."},
               };
        }

        public static List<Recipe> Recipes
        {
            get { return recipes; }
        }

        public static void AddRecipe(Recipe movie)
        {
            recipes.Add(movie);
        }

        public static Recipe GetById(int id)
        {
            return recipes.FirstOrDefault(i => i.Id == id);
        }

        public static void DeleteRecipe(Recipe r)
        {
            recipes.Remove(r);
        }

        public static Recipe UpdateRecipe(int id, string name, string ımage, string description, string time, string difficulty, string ingredients, string tipsAndTricks, int numberOfLikes)
        {
            Recipe x = GetById(id);
            x.Name = name;
            x.Description = description;
            x.time = time;
            x.difficulty = difficulty;
            x.ingredients = ingredients;
            x.tipsAndTricks = tipsAndTricks;
            x.numberOfLikes = numberOfLikes;
            return recipes.FirstOrDefault(i => i.Id == id);
        }
    }
}
