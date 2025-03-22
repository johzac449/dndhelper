using Microsoft.AspNetCore.Mvc;
using Characters.Models;

namespace dndhelper.Controllers;

public class dndhelperController : Controller
{
    public IActionResult Index()
    {
        // Generate a mock subscriber for demonstration
        var character = new Character
        {
            Id = Guid.NewGuid().ToString(), // Generate unique GUID
            Name = "Kalle",
            CClass = "Tjuv"
            Race = "Anka"
        };
        
        // Log the creation of the subscriber (for debugging)
        Console.WriteLine($"Character {character.Name}, {character.Email} with ID: {character.Id} created");

        // Pass the subscriber to the view
        return View(character);
    }
}
