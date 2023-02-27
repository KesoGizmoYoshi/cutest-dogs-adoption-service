namespace CutestDogsAdoptionService.Models;

public class DogModel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Cuteness { get; set; }
    public string? Image { get; set; }
    public bool Adopted { get; set; }
}
