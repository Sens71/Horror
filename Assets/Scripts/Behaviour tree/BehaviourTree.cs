public class BehaviourTree : Node
{
    public BehaviourTree()
    {



    }
    public override Status Process()
    {
        foreach (Node child in children)
        { 
            Status status = child.Process();
            if (status != Status.Success)
            {
                return status;
            }
            currentChild++;
        }
        return Status.Success;
    }

}

