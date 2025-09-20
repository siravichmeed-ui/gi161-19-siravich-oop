using UnityEngine;

public class Newfarm : Animal
{
    public override void MakeSound()
    {

        Debug.Log($"{Name} say meowwww");
    }
}
