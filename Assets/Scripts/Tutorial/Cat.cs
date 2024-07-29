using UnityEngine;

public class Cat: Animal
{
    public Cat mother;
    public Animal enemy;

    public Cat(int age, string name, float weight) : base(age, name, weight)
    {
    }

    public override void Voice()
    {
        Debug.Log("Meow");
    }
    
}
