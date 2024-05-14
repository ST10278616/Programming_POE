using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PROGRAMMING_PART2
{
    /// <summary>
    /// Interaction logic for RecipeDetailsWindow.xaml
    /// </summary>
    public partial class RecipeDetailsWindow : Window
    {
        // Constructor to receive recipe details
        public RecipeDetailsWindow(string recipeName, string ingredients, string steps, double calories)
        {
            InitializeComponent();

            // Display recipe details in text blocks or any other controls
            RecipeNameTextBlock.Text = recipeName;
            IngredientsTextBlock.Text = ingredients;
            StepsTextBlock.Text = steps;
            CaloriesTextBlock.Text = calories.ToString();
        }
    }
}

