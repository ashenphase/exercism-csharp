public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}
public class Allergies
{
    private int _mask;
    public Allergies(int mask)
    {
        _mask = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return ((int)allergen & _mask) != 0;
    }

    public Allergen[] List()
    {
        return Enum.GetValues<Allergen>()
            .Where(n => IsAllergicTo(n))
            .ToArray();
    }
}