using Microsoft.AspNetCore.Mvc;
using PackardJAllForOneWebApi.Services.RestaurantPicker;

namespace PackardJAllForOneWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantPickerController : ControllerBase
{
    private readonly IRestaurantPickerService _restaurantPickerService;

    public RestaurantPickerController(IRestaurantPickerService restaurantPickerService)
    {
        _restaurantPickerService = restaurantPickerService;
    }

    [HttpGet]
    [Route("RestaurantPicker/{userChoice}")]
    public string RestaurantPicker(string userChoice)
    {
        return _restaurantPickerService.RestaurantPicker(userChoice);
    }
}
