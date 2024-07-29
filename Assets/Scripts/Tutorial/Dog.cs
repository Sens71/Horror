using UnityEngine;

public class Dog : Animal
{   
    public Color furColor;
    public Dog(int age, string name, float weight) : base(age, name, weight)
    {
    }

    public override void Voice()
    {
        Debug.Log("woof");
    }
}