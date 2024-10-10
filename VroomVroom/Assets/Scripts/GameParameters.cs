using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameParameters
{
    public static float scoreMultiplier = 1f;
    public static float jumpForce = -5;
    public static int secondsWithSuperJump = 5;
    public static int lives = 3;
    public static int totalLevels = 6;
    public static int level = 0;
    public static int levelDistance = 7;
    public static int slowDownTime = 3;

    public static int ObstacleSecondsOnScreen = 3;

    public static int ObstacleMinimumTimeToCreation = 3;
    public static int ObstacleMaximumTimeToCreation = 5;

    public static int FallingObstacleMinimumTimeToCreation = 4;
    public static int FallingObstacleMaximumTimeToCreation = 5;

    public static int TimesToMoveInSameDirection = 30;
    public static int TimeToCompleteLevel = 30;
    public static int TimeToDeincrementLevel = 3;
}
