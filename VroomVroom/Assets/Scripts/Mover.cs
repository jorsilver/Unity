using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Mover 
{
    public static float speed = -0.1f;
    private static float amountToSlow = 0.0025f;

    public static bool isMoving = true;

    public static void StartMoving()
    {
        isMoving = true;
    }

    public static void StopMoving()
    {
        isMoving = false;
    }

    public static float GetSpeed()
    {
        return speed;
    }

    public static void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public static void SlowDown()
    {
        speed = speed + amountToSlow;
        if (speed == 0f)
            speed = -0.01f;
    }

    public static void Move(SpriteRenderer spriteToMove)
    {
        if (isMoving)
            spriteToMove.transform.Translate(0f, speed, 0f, Space.World);
    }

    public static bool IsOffScreen(SpriteRenderer spriteRenderer, float destroyPosition)
    {
        if (spriteRenderer.transform.position.y <= destroyPosition)
            return true;
        return false;
    }
}
