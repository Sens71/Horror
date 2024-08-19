using UnityEngine;

public class Mouse:Animal
{
    public Mouse mother;
    public Animal enemy;

    public Mouse(int age, string name, float weight) : base(age, name, weight)
    {

    }
    
    public override void Voice()
    {
        Debug.Log("squeak");
    }
    
}
