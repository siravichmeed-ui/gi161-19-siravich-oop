using UnityEngine;

public class Cow : MonoBehaviour
{
    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) { name = "Cow"; }
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
            if (value < 0) happiness = 0;
            else if (value > 50) happiness = 50;
            else happiness = value;
        }
    }
    private float milk;
    public float Milk
    {
        get { return milk; }
        private set
        {
            if (value < 0) milk = 0;
            else milk = value;
        }
    }
    public Cow(string newName, int newHG, int newHPN, float newMilk)
    {
        Name = newName;
        hunger = newHG;
        happiness = newHPN;
        milk = newMilk;
    }

    // Methods
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

    public void Moo()
    {
        Debug.Log($"{Name} says: มออออออ");
        AdjustHappiness(+10);
    }

    public void ShowStats()
    {
        Debug.Log($"[Cow] Name:{Name} | Hunger:{Hunger} | Happiness:{Happiness} | Milk:{Milk}");
    }
}
