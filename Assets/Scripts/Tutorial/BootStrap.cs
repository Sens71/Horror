using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootStrap : MonoBehaviour
{
    public Renderer renderer;
    void Start()
    {
        Cat cat1 = new Cat(2,"catt",7);


        Cat cat2 = new Cat(5, "cattttttttt", 4);

       
       

        Dog dog1 = CreateDog(2, "dggd",9);
        renderer.material.color = dog1.furColor;
        cat2.mother = cat1;
        cat2.enemy = dog1;

        Mouse mouse1 = new Mouse(1, "uyefefe",0.5f);

        PetAnimal(cat1);
        PetAnimal(dog1);
        PetAnimal(mouse1);

        print(hfsf(3,4));

    }
    private void PetAnimal(Animal pet)
    {
        pet.Voice();
    }
    
    public int hfsf(int a, int b)
    {
        int fhfdg = a + b;
        int fhfdg2 = a - b;
        int fhfdg3 = fhfdg * fhfdg2;
        return fhfdg3;
    }
    private Dog CreateDog(int age, string name, float weight)
    {   
        Color color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
        Dog dog = new Dog(age, name, weight);
        dog.furColor = color;
        return dog;
    }



    
}
