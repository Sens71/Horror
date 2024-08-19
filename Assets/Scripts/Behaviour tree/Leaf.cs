﻿public class Leaf : Node
{
    public readonly IStrategy strategy;

    public Leaf(string name, IStrategy strategy) : base(name)
    {
        this.strategy = strategy;
    }
    public override Status Process() => strategy.Process();
    public override void Reset() => strategy.Reset();
    

}
