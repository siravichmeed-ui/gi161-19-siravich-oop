using UnityEngine;

public class Cow : Animal
{
    public float TotalMilk { get; private set; }
    /*private float milk;
    public float Milk
    {
        get { return milk; }
        set
        {
            if (value >= 0) milk = value;
            else milk = 0;
        }
    }*/


    public override void MakeSound()
    {

        Debug.Log($"{Name} say Moo!");  
    }

    public override void SpecialAction()
    {
        base.SpecialAction();
        Debug.Log($"{Name} gives a loud MooMooMoo| current Happiness: {Happiness}");
        AdjustHunger(5);
        AdjustHappiness(10);
    }

    public Cow()
    {
        PreferredFood = FoodTypes.Hay;
    }
    public override string ProduceProduct()
    {
        if (Happiness <= 70)
            return $"{Name} is not happy enough to produce milk.";

        int units = Happiness / 10;
        TotalMilk += units;
        
        return $"{Name} produced 10 liters of milk. Total milk: {TotalMilk} liters.";
    }

}
