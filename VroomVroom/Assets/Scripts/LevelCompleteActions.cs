using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleteActions : MonoBehaviour
{
    public CountDownTimer CountDownTimer;

    float activeGameSpeed = Mover.GetSpeed();

    public void LevelModifier()
    {
        CountDownTimer.CountdownReset();
        CountDownTimer.ScoreMultiplierIncreaser();
    }
}
