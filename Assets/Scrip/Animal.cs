using System;
using System.Collections.Generic;
using UnityEngine;


public abstract class Animal : MonoBehaviour
{

    public string Name { get; private set; }
    public int Hunger { get; private set; }
    public int Happiness { get; private set; }
    public FoodTypes PreferredFood { get; protected set; }

    public virtual void Init(string newName)
    {
        // กันค่าชื่อว่าง/space/null
        Name = string.IsNullOrWhiteSpace(newName) ? "Unknown" : newName;

        // ค่าเริ่มต้นตามใบงาน
        Hunger = 50;
        Happiness = 50;
    }

    public void AdjustHunger(int amount)
    {
        Hunger = Mathf.Clamp(Hunger + amount, 0, 100);
        /*Hunger -= amount;
        if (Hunger < 0) Hunger = 0;*/
    }
    public void AdjustHappiness(int amount)
    {
        Happiness = Mathf.Clamp(Happiness + amount, 0, 100);
        /*Happiness += amount;
        if (Happiness < 0) Happiness = 0;*/
    }
    
    public void Feed(int foodAmount)
    {
        if (foodAmount < 0) foodAmount = 0;

        
        AdjustHunger(-foodAmount);
        AdjustHappiness(foodAmount / 2);

        Debug.Log($"{Name} was fed {foodAmount}. Happiness now {Happiness}.");
        /*AdjustHunger(foodAmount);
        Debug.Log($"{Name} has been fed with {foodAmount} units of food.");*/
    }
    public void Feed(FoodTypes type, int amount)
    {
        if (amount < 0) amount = 0;

        
        if (type == FoodTypes.RottenFood)
        {
            AdjustHappiness(-20);
            Debug.Log($"{Name} got RottenFood! Happiness now {Happiness}.");
            return;
        }

        
        if (type == PreferredFood)
        {
            AdjustHunger(-amount);
            AdjustHappiness(+15);
            Debug.Log($"{Name} loves {type}! +15 happiness ? {Happiness}.");
        }
        else
        {
            
            Feed(amount);
        }
    }
    /* public void Feed(string foodType, int foodAmount)
     {
         AdjustHunger(foodAmount);
         Debug.Log($"{Name} has been fed with {foodAmount} units of {foodType} food.");
     }*/
    public virtual void ShowStatus()
    {
        Debug.Log($"Animal name: {Name} | Animal Hunger: {Hunger} | Animal Happiness: {Happiness} | Preferedfood: {PreferredFood} ");
    }

    public virtual void SpecialAction()
    {
        Debug.Log($"{Name} does a special action!");
    }

    public abstract void MakeSound();
    public abstract string ProduceProduct();


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

