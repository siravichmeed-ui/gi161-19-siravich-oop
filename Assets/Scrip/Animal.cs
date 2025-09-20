using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) { name = "Unknown Animal"; }
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
    public void Init(string newName, int newHunger, int newHappiness)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;

    }
    public void AdjustHunger(int amount)
    {
        Hunger -= amount;
        if (Hunger < 0) Hunger = 0;
    }
    public void AdjustHappiness(int amount)
    {
        Happiness += amount;
        if (Happiness < 0) Happiness = 0;
    }
    public virtual void MakeSound()
    {
        Debug.Log($"Animal sounds??");
    }
    public void Feed(int foodAmount)
    {
        AdjustHunger(foodAmount);
        Debug.Log($"{Name} has been fed with {foodAmount} units of food.");
    }
    public void Feed(string foodType, int foodAmount)
    {
        AdjustHunger(foodAmount);
        Debug.Log($"{Name} has been fed with {foodAmount} units of {foodType} food.");
    }
    public virtual void ShowStatus()
    {
        Debug.Log($"Animal name: {Name} | Animal Hunger: {Hunger} | Animal Happiness: {Happiness} ");
    }

    public virtual void SpecialAction()
    {
        Debug.Log($"{Name} does a special action!");
    }
}



















































/*public string Name { get; private set; }
public int Hunger { get; private set; }
public int Happiness { get; private set; }

public string Makesound { get; private set; }



public void Init(string newName, int newHG, int newHPN)
{
    Name = newName;
    Hunger = newHG;
    Happiness = newHPN;



}
public void AdjustHunger(int amount)
{
    Hunger += amount;

}

public void AdjustHappiness(int amount)
{
    Happiness += amount;

}


public virtual void Feed(int amount)
{
    AdjustHunger(-amount);
    Debug.Log($"{Name} received food amount {amount}");
}

public virtual void Feed(string foodName, int amount)
{
    AdjustHunger(-amount);
    Debug.Log($"{Name} received {foodName} amount {amount}");
}

public virtual void GetStatus()
{
    Debug.Log($"{Name} | Hunger:{Hunger} | Happiness:{Happiness}");
}
public virtual void MakeSound()
{
    Debug.Log($"{Name} says: {Makesound}");
}*/

