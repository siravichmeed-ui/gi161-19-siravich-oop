using UnityEngine;

public class Chicken : Animal
{
    private int eggs;
    public int Eggs
    {
        get { return eggs; }
        set
        {
            if (value >= 0) eggs = value;
            else eggs = 0;
        }
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

    

}
