using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_GatherResources : Goal_Base
{
    [SerializeField] int Priority = 10;



    public override void PreTick()
    {
        CanRun = true; 
        Priority = 0;
    }
}
