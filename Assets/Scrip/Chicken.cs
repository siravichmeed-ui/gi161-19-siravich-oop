using UnityEngine;

public class Chicken : Animal
{
    public int Eggs { get; private set; }
    /*private int eggs;
    public int Eggs
    {
        get { return eggs; }
        set
        {
            if (value >= 0) eggs = value;
            else eggs = 0;
        }
    }*/

    public Chicken()
    {
        PreferredFood = FoodTypes.Grain;
    }



    public override void MakeSound()
    {

        Debug.Log($"{Name} say Cluck Cluck!");
    }


    public override void SpecialAction()
    {
        base.SpecialAction();
        Debug.Log($"{Name} slept and feels alittle hungry, but very happy");
        AdjustHunger(5);
        AdjustHappiness(10);
    }

    public override string ProduceProduct()
    {
        int laid = 0;
        if (Happiness <= 50) laid = 0;
        else if (Happiness <= 79) laid = 2;
        else laid = 3;

        Eggs += laid;
        return $"{Name} produced {laid} eggs. Total eggs: {Eggs} eggs.";
        
    }

}
