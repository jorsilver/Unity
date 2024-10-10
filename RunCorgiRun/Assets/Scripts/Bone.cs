using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bone : TimedLifespan
{
    public override void Start()
    {
        SecondsOnScreen = GameParameters.BoneSecondsOnScreen;
        base.Start();
    }
}
