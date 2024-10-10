using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonePlacer : RandomTimedObjectPlacer
{
    public override void Start()
    {
        MinimumTimeToCreation = GameParameters.BoneMinimumTimeToCreation;
        MaximumTimeToCreation = GameParameters.BoneMaximumTimeToCreation;
        base.Start();
    }

    public override void Create()
    {
        Instantiate(Prefab, ScreenPositionTools.RandomWorldLocation(Camera), Quaternion.identity);
        base.Create();
    }
}
