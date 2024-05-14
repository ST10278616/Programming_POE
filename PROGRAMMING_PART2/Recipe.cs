using System;
using System.Collections.Generic;
using System.Linq;

namespace PROGRAMMING_PART2
{
    class Program
    {
        static void jain(string[] args)
        {
            List<Recipe> recipes = new List<Recipe>();

            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add a new recipe");
                Console.WriteLine("2. Display all recipes");
                Console.WriteLine("3. Select a recipe to display");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewRecipe(recipes);
                        break;
                    case "2":
                        DisplayAllRecipes(recipes);
                        break;
                    case "3":
                        SelectAndDisplayRecipe(recipes);
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddNewRecipe(List<Recipe> recipes)
        {
            Console.Write("Enter recipe name: ");
            string name = Console.ReadLine();
            Recipe recipe = new Recipe(name);

            while (true)
            {
                Console.WriteLine("Enter ingredient details (or type 'done' to finish):");
                Console.Write("Ingredient name: ");
                string ingredientName = Console.ReadLine();
                if (ingredientName.ToLower() == "done")
                    break;

                Console.Write("Quantity: ");
                double quantity = Convert.ToDouble(Console.ReadLine());

                Console.Write("Unit: ");
                string unit = Console.ReadLine();

                Console.Write("Calories: ");
                double calories = Convert.ToDouble(Console.ReadLine());

                Console.Write("Food group: ");
                string foodGroup = Console.ReadLine();

                recipe.AddIngredient(ingredientName, quantity, unit, calories, foodGroup);
            }

            recipes.Add(recipe);
            Console.WriteLine($"Recipe '{name}' added successfully!");
        }

        static void DisplayAllRecipes(List<Recipe> recipes)
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes found.");
                return;
            }

            Console.WriteLine("List of Recipes:");
            foreach (var recipe in recipes.OrderBy(r => r.Name))
            {
                Console.WriteLine($"- {recipe.Name}");
            }
        }

        static void SelectAndDisplayRecipe(List<Recipe> recipes)
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes found.");
                return;
            }

            Console.WriteLine("Select a recipe to display:");
            for (int i = 0; i < recipes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {recipes[i].Name}");
            }

            Console.Write("Enter the number of the recipe: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index < 0 || index >= recipes.Count)
            {
                Console.WriteLine("Invalid recipe number.");
                return;
            }

            Recipe selectedRecipe = recipes[index];
            DisplayRecipeDetails(selectedRecipe);
        }

        static void DisplayRecipeDetails(Recipe recipe)
        {
            Console.WriteLine($"Recipe: {recipe.Name}");
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in recipe.Ingredients)
            {
                Console.WriteLine($"- {ingredient.Quantity} {ingredient.Unit} of {ingredient.Name} ({ingredient.Calories} calories, {ingredient.FoodGroup})");
            }
            Console.WriteLine($"Total Calories: {recipe.CalculateTotalCalories()}");

            if (recipe.ExceedsCaloriesLimit(300))
            {
                recipe.NotifyCalorieLimitExceeding();
            }
        }
    }

    class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Recipe(string name)
        {
            Name = name;
            Ingredients = new List<Ingredient>();
        }

        public void AddIngredient(string name, double quantity, string unit, double calories, string foodGroup)
        {
            Ingredients.Add(new Ingredient(name, quantity, unit, calories, foodGroup));
        }

        public double CalculateTotalCalories()
        {
            double totalCalories = 0;
            foreach (var ingredient in Ingredients)
            {
                totalCalories += ingredient.Calories;
            }
            return totalCalories;
        }

        public bool ExceedsCaloriesLimit(double limit)
        {
            return CalculateTotalCalories() > limit;
        }

        // Other methods and event handling for notifying about calorie limit exceeding can be added here

        // Placeholder method for notifying about calorie limit exceeding
        public void NotifyCalorieLimitExceeding()
        {
            // Implement notification mechanism here
            Console.WriteLine($"Warning: Total calories for recipe '{Name}' exceed the limit!");
        }
    }

    class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public double Calories { get; set; }
        public string FoodGroup { get; set; }

        public Ingredient(string name, double quantity, string unit, double calories, string foodGroup)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            Calories = calories;
            FoodGroup = foodGroup;
        }
    }
}
