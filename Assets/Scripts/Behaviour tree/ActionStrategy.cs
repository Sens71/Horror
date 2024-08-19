using System;
using UnityEngine;

public class ActionStrategy : IStrategy
{

    public readonly Action action;

    public ActionStrategy(Action action)
    {
        this.action = action;
    }
    public Node.Status Process()
    {
        action();
        return Node.Status.Success;
    }
}