using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class BootStrap : MonoBehaviour
{
    private Node mainNode;
    void Start()
    {
        mainNode = new("Main Node", 0);

        Dog dog1 = new Dog(1, "fesf", 2);
        dog1.MethodTest();
        ActionStrategy simpleAction = new ActionStrategy(Empty);
        Leaf leaf1 = new("Leaf",simpleAction);
        mainNode.AddChild(leaf1);
        mainNode.Process();
    }
    public void Empty()
    {
        print("rra");
    }
    
}
