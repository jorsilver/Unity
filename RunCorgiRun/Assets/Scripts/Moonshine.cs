using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moonshine : TimedLifespan
{
    public override void Start()
    {
        SecondsOnScreen = GameParameters.MoonshineSecondsOnScreen;
        base.Start();
    }
}
