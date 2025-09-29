using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Main : MonoBehaviour
{


    



    public List<Animal> animalsPrefabs; 
    public Animal currentAnimal; 
    public List<Animal> animals = new List<Animal>();
    void Start()
    {
        //chick
        currentAnimal = Instantiate(animalsPrefabs[0]);
        currentAnimal.Init("Chick");
        animals.Add(currentAnimal);

        //Cow
        currentAnimal = Instantiate(animalsPrefabs[1]);
        currentAnimal.Init("Cow");
        animals.Add(currentAnimal);

        //Piggy
        currentAnimal = Instantiate(animalsPrefabs[2]);
        currentAnimal.Init("Piggy");
        animals.Add(currentAnimal);


        Debug.Log($"Welcome to Arizona Farm");
        Debug.Log($"There are {animals.Count} animals living in the Arizona Farm ");

        foreach (var animal in animals)
        {
            animal.ShowStatus();

        }
        foreach (var animal in animals)
        {
            animal.MakeSound();
            animal.Feed(5);
        }

        animals[0].Feed(10);
        animals[0].Feed(FoodTypes.Grain, 5);
        Debug.Log(animals[0].ProduceProduct());
        animals[0].Feed(FoodTypes.Grain, 5);
        Debug.Log(animals[0].ProduceProduct());


        /*//chick
        currentAnimal = Instantiate(animalsPrefabs[0]);
        currentAnimal.Init("Chick");
        animals.Add(currentAnimal);

        //Cow
        currentAnimal = Instantiate(animalsPrefabs[1]);
        currentAnimal.Init("Cow");
        animals.Add(currentAnimal);

        //Piggy
        currentAnimal = Instantiate(animalsPrefabs[2]);
        currentAnimal.Init("Piggy");
        animals.Add(currentAnimal);

        Debug.Log($"Welcome to Arizona Farm");
        Debug.Log($"There are {animals.Count} animals living in the Arizona Farm ");

        //show status
        foreach (var animal in animals)
        {
            animal.ShowStatus();

        }
        foreach (var animal in animals)
        {
            animal.MakeSound();
            animal.Feed(5);
        }





        animals[0].Feed("Rice", 3);
        animals[0].SpecialAction();
        animals[0].ShowStatus();

        
        animals[1].Feed("Hay", 5);
        animals[1].SpecialAction();
        animals[1].ShowStatus();

        
        animals[2].Feed("Carrot", 5);
        animals[2].MakeSound();
        animals[2].ShowStatus();*/

    }
}



