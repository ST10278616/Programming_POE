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
    /// Interaction logic for AddRecipeWindow.xaml
    /// </summary>
    public partial class AddRecipeWindow : Window
    {
        // Store recipe details here
        // Nullable fields
        private string? recipeName;
        private string? ingredients;
        private string? steps;
        private double calories;

        public AddRecipeWindow()
        {
            InitializeComponent();
        }

        // Handler for Save button click
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve inputs from text boxes
            recipeName = RecipeNameTextBox.Text;
            ingredients = IngredientsTextBox.Text;
            steps = StepsTextBox.Text;
            calories = double.Parse(CaloriesTextBox.Text);

            // Optionally, you can save these details to a database or list for future reference
        }

        // Handler for View Details button click
        private void ViewDetailsButton_Click(object sender, RoutedEventArgs e)
        {
            // Pass the recipe details to RecipeDetailsWindow
            RecipeDetailsWindow detailsWindow = new RecipeDetailsWindow(recipeName, ingredients, steps, calories);
            detailsWindow.Show();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Close the Add Recipe Window without saving any changes
            this.Close();
        }

        internal void CancelButton_Click(object value1, object value2)
        {
            throw new NotImplementedException();
        }
    }
}
