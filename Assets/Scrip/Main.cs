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
        chicken.Getstatus();
        chicken.MakeSound();
        chicken.Feed("corn");
        chicken.Getstatus();
        chicken.Sleep();
        chicken.Getstatus();

        Debug.Log($"=== Hydra ===");
        cow.Getstatus();
        cow.Moo();
        cow.Feed("grass");
        cow.MakeSound();
        cow.Getstatus();

        Debug.Log("Goodbye");
    }

    
}
