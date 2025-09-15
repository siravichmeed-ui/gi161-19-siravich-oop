using UnityEngine;

public class Chicken : MonoBehaviour
{
    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) { name = "Chicken"; }
            else name = value;
        }
    }
    private int hunger;
    public int Hunger
    {
        get { return hunger; }
        set
        {
            if (value < 0) hunger = 0;
            else if (value > 50) hunger = 50;
            else hunger = value;
        }
    }
    private int happiness;
    public int Happiness
    {
        get { return happiness; }
        set
        {
            if (value < 0 ) happiness = 0;
            else if ( value > 50 ) happiness = 50;
            else happiness = value;
        }
    }
    private int eggs;
    public int Eggs
    {
        get { return eggs; }
        set
        {
            if (value < 0) eggs = 0;
            else eggs = value;
        }
    }
    public Chicken(string newName, int newHG, int newHPN, int newEGG)
    {
        Name = newName;
        hunger = newHG;
        happiness = newHPN;
        eggs = newEGG;

    }
    public void AdjustHunger(int amount)
    {
        Hunger += amount;
        
    }

    public void AdjustHappiness(int amount)
    {
        Happiness += amount;
        
    }

    public void Feed(string food)
    {
        Debug.Log($"{Name} eats {food}");
        AdjustHunger(-10);
        AdjustHappiness(+5);
    }

    public void Sleep()
    {
        Debug.Log($"{Name} is sleeping...");
        AdjustHunger(+5);
        AdjustHappiness(+10);
    }

    public void MakeSound()
    {
        Debug.Log($"{Name} says: µéÒ¡ææææ ");
    }

    public void Getstatus()
    {
        Debug.Log($"[Chicken] Name:{Name} | Hunger:{Hunger} | Happiness:{Happiness} | Eggs:{Eggs}");
    }

}
