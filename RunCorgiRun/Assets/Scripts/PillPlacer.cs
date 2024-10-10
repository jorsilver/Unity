using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillPlacer : RandomTimedObjectPlacer
{
    public override void Start()
    {
        MinimumTimeToCreation = GameParameters.PillMinimumTimeToCreation;
        MaximumTimeToCreation = GameParameters.PillMaximumTimeToCreation;
        base.Start();
    }

    public override void Create()
    {
        Instantiate(Prefab, ScreenPositionTools.RandomWorldLocation(Camera), Quaternion.identity);
        base.Create();
    }
}
