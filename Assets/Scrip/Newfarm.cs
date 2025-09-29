using UnityEngine;

public class Newfarm : Animal
{
    public int NewResource { get; private set; }
    public override void MakeSound()
    {

        Debug.Log($"{Name} say oodddddd");
    }
    public Newfarm()
    {
        PreferredFood = FoodTypes.Carrot;
    }
    public override string ProduceProduct()
    {
        if (Happiness == 100)
        {
            NewResource += 1;  
            return $"Total NewResource: {NewResource}";
        }

        
        return $"{Name} isn't at max happiness yet ({Happiness}/100).";
        
    }
}
