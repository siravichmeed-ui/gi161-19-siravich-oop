using UnityEngine;

public class Main : MonoBehaviour
{
    
    void Start()
    {
        Chicken chicken = new Chicken("Dragon",10,10,0);
        Cow cow = new Cow("Hydra",10,10,0);
        Debug.Log("Welcome to Arizona Farm");
        Debug.Log($"Dragon and Hydra are living in the farm");
        Debug.Log($"=== Dragon ===");
        chicken.ShowStats();
        chicken.MakeSound();
        chicken.Feed("corn");
        chicken.ShowStats();
        chicken.Sleep();
        chicken.ShowStats();

        Debug.Log($"=== Hydra ===");
        cow.ShowStats();
        cow.Feed("grass");
        cow.Sleep();
        cow.Moo();
        cow.ShowStats();

        Debug.Log("Goodbye");
    }

    
}
