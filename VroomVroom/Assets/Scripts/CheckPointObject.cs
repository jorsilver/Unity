using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointObject : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;

    void Update()
    {
        Mover.Move(SpriteRenderer);
        if (GameParameters.level < GameParameters.totalLevels)
        {
            if (Mover.IsOffScreen(SpriteRenderer, -5f))
                Destroy(gameObject);
        }
    }
}
