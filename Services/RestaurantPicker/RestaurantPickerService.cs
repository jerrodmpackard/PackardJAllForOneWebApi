namespace PackardJAllForOneWebApi.Services.RestaurantPicker;

public class RestaurantPickerService : IRestaurantPickerService
{
    public string RestaurantPicker(string userChoice)
    {
        string[] fastFood = { "McDonald's", "Burger King", "In-n-Out", "Wendy's", "Sonic", "Jack in the Box", "Carl's Jr.", "Chick-fil-A", "Taco Bell", "The Habit" };
        string[] restaurant = { "Olive Garden", "Red Robin", "Red Lobster", "Buffalo Wild Wings", "Applebee's", "Chili's", "Black Bear Diner", "IHOP", "Denny's", "BJ's" };
        string[] pizza = { "Mountain Mike's", "Little Caesars", "Papa John's", "Pizza Hut", "Domino's", "Round Table", "Pizza Guys", "Eddie's Pizza", "David's Pizza", "Michael's Pizza" };

        Random randomClass = new Random();
        int arrayChoice = randomClass.Next(0, 10);

        if (userChoice.ToLower() == "fast food")
        {
            return $"Your randomly generated Fast Food restaurant is {fastFood[arrayChoice]}!";
        }
        else if (userChoice.ToLower() == "restaurant")
        {
            return $"Your randomly generated Restaurant is {restaurant[arrayChoice]}!";
        }
        else if (userChoice.ToLower() == "pizza")
        {
            return $"Your randomly generated Pizza Place is {pizza[arrayChoice]}!";
        }
        else
        {
            return "Please enter \"fast food\", \"restaurant\", or \"pizza\".";
        }
    }
}
