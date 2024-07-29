
public abstract class Animal
{
    public int age;
    public string name;
    public float weight;

    public Animal(int age, string name,float weight)
    {
        this.age = age;
        this.name = name;
        this.weight = weight;
    }
    public abstract void Voice();
}
