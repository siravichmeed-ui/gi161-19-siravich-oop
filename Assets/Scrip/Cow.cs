using UnityEngine;

public class Cow : Animal
{

    private float milk;
    public float Milk
    {
        get { return milk; }
        set
        {
            if (value >= 0) milk = value;
            else milk = 0;
        }
    }

    
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

    

}
