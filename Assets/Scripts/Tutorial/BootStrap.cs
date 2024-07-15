using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootStrap : MonoBehaviour
{
    
    void Start()
    {
        Cat cat1 = new Cat(2,"catt");
       

        Cat cat2 = new Cat(5,"cattttttttt");
        
        cat2.mother = cat1;

        Dog dog1 = new Dog(2,"dggd");
     
        print(dog1);
    }

    
}
