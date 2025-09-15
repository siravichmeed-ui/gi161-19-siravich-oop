using UnityEngine;

public class Main : MonoBehaviour
{
    
    void Start()
    {
        Chicken chicken = new Chicken("Dragon",10,10,0);
        Cow cow = new Cow("Hydra",10,10,0);
        Debug.Log("Welcome to Arizona Farm");
        Debug.Log($"{chicken} and {cow}");
        Debug.Log("=== Chicken ===");
        chicken.ShowStats();
        chicken.Feed("corn");
        chicken.Sleep();
        chicken.MakeSound();
        chicken.ShowStats();

        Debug.Log("=== Cow ===");
        cow.ShowStats();
        cow.Feed("grass");
        cow.Sleep();
        cow.Moo();
        cow.ShowStats();

        Debug.Log("Goodbye");
    }

    
}
