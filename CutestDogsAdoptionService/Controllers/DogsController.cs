using CutestDogsAdoptionService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CutestDogsAdoptionService.Controllers;
public class DogsController : Controller
{
    private static List<DogModel> dogs = new()
    {
        new DogModel()
        {
            Id = 1,
            Name = "Yoshi",
            Cuteness = new Random().Next(1,11),
            Image = "doggo 1.png",
            Adopted = false
        },
        new DogModel()
        {
            Id = 2,
            Name = "Gizmo",
            Cuteness = new Random().Next(1,11),
            Image = "doggo 2.png",
            Adopted = false
        },
        new DogModel()
        {
            Id = 3,
            Name = "Keso",
            Cuteness = new Random().Next(1,11),
            Image = "doggo 3.png",
            Adopted = false
        }
    };
    public IActionResult Index()
    {
        List<DogModel> dogsInOrder = dogs.OrderBy(d => d.Name).ToList();

        List<DogModel> superCuteDogs = dogs.Where(d => d.Cuteness > 5).ToList();

        ViewData["cutnessOver5"] = dogs.Where(d => d.Cuteness > 5).ToList().Count();

        return View(dogsInOrder);
    }

    public IActionResult Details(int id)
    {
        DogModel? dog = dogs.FirstOrDefault(d => d.Id.Equals(id));
        if(dog != null && !dog.Adopted)
        {
            dog.Adopted = true;
        }

        return View(dog);
    }
}
