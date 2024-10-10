using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonshinePlacer : RandomTimedObjectPlacer
{
    public override void Start()
    {
        MinimumTimeToCreation = GameParameters.MoonshineMinimumTimeToCreation;
        MaximumTimeToCreation = GameParameters.MoonshineMaximumTimeToCreation;
        base.Start();
    }

    public override void Create()
    {
        Instantiate(Prefab, ScreenPositionTools.RandomTopOfScreenWorldLocation(Camera), 
            Quaternion.identity);
        base.Create();
    }
}
