using Microsoft.AspNetCore.Mvc;
using Characters.Models;

namespace dndhelper.Controllers;

public class dndhelperController : Controller
{
    public IActionResult Index()
    {
        // Generate a mock character for demonstration
        var character = new Character
        {
            Id = Guid.NewGuid().ToString(), // Generate unique GUID
            Name = "Kalle",
            CClass = "Tjuv"
            Race = "Anka"
        };
        
        // Log the creation of the character (for debugging)
        Console.WriteLine($"Character {character.Name}, {character.Email} with ID: {character.Id} created");

        // Pass the character to the view
        return View(character);
    }

    [HttpGet]
    public IActionResult Character()
    {
        return View(new Character());
    }

    [HttpPost]
    public async Task<IActionResult> Character(Character character)
    {
        // Validate the model state
        if (ModelState.IsValid)
        {
            // Log the character details
            Console.WriteLine($"Name: {character.Name}, Class: {character.CClass}, Race: {character}");

            // TODO: Implement the character logic
            await Task.Delay(100); // Simulate an operation

            // Set a result message in TempData in order to display it in the view
            TempData["SuccessMessage"] = "Karaktären tillagd!";

            // Redirect back to the character GET action to clear the form
            return RedirectToAction("Subscribe");
        }

        // If the model state is invalid, redisplay the form with validation errors
        return View(character);
    }
}
