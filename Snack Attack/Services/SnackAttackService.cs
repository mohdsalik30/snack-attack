using Snack_Attack.Models;

namespace Snack_Attack.Services;

public class SnackAttackService
{
    private static readonly IEnumerable<Models.SnackItem> _fastFood = new List<Models.SnackItem>
    {
        new Models.SnackItem { Name = "Chicken Burger 1", Image = "burger1.png", Price = 4.5 },
        new Models.SnackItem { Name = "Chicken Burger 2", Image = "burger2.png", Price = 5.5 },
        new Models.SnackItem { Name = "Chicken Burger Meal", Image = "burger3.png", Price = 6.5 },
        new Models.SnackItem { Name = "Cheese Burger", Image = "cheeseburger.png", Price = 5.5 },
        new Models.SnackItem { Name = "Chicken Wings", Image = "chicken_wings.png", Price = 1.2 },
        new Models.SnackItem { Name = "Cola", Image = "cola.png", Price = 1 },
        new Models.SnackItem { Name = "Cola Bottle", Image = "cola_bottle.png", Price = 1.2 },
        new Models.SnackItem { Name = "Lemon Soda", Image = "soda.png", Price = 1.2 },
        new Models.SnackItem { Name = "Fries", Image = "french_fries.png", Price = 1.5 },
        new Models.SnackItem { Name = "Full Chicken", Image = "fried_chicken.png", Price = 12.5 },
        new Models.SnackItem { Name = "Chicken", Image = "fried_chicken1.png", Price = 2 },
        new Models.SnackItem { Name = "Mayonnaise", Image = "mayonnaise.png", Price = 0.3 },
        new Models.SnackItem { Name = "Ketchup", Image = "tomato_sauce.png", Price = 0.3 }
    };

  
    public static IEnumerable<Models.SnackItem> GetAllFastFood() => _fastFood;

   
    public IEnumerable<Models.SnackItem> GetPopularItems(int count = 6) =>
        _fastFood.OrderBy(p => Guid.NewGuid()).Take(count);

    public IEnumerable<SnackItem> GetSnackItems() =>
        _fastFood;
    public IEnumerable<Models.SnackItem> SearchItems(string searchTerm) =>
        string.IsNullOrWhiteSpace(searchTerm)
            ? _fastFood
            : _fastFood.Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
}