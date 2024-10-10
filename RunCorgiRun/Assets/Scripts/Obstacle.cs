using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public void Start()
    {

    }

    void Update()
    {
        Mover.Move(spriteRenderer);
        if (IsOffscreen())
            Destroy(gameObject);
    }

    private bool IsOffscreen()
    {
        if (spriteRenderer.transform.position.y <= -5f)
            return true;
        return false;
    }
}
