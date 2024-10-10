using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beer : TimedLifespan
{
    public override void Start()
    {
        SecondsOnScreen = GameParameters.BeerSecondsOnScreen;
        base.Start();
    }
}
