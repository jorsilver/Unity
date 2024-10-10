using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    private int laneNumber;
    private float xAdjustmentAmount = 0.01f;

    public void Start()
    {

    }

    void Update()
    {
        Mover.Move(spriteRenderer);
        // if we're in left lane, adjustment direction will be negative,
        // if right lane, positive
        // if middle lane, zero
        // adjust a little bit in the x direction
        float adjustmentMultiplier = 0f;

        if (laneNumber == 1)
            adjustmentMultiplier = 1f;
        else if (laneNumber == 3)
            adjustmentMultiplier = -1f;

        transform.Translate(new Vector3(xAdjustmentAmount * adjustmentMultiplier, 0f, 0f));

        if (IsOffscreen())
            Destroy(gameObject);
    }

    public void SetLaneNumber(int number)
    {
        laneNumber = number;
    }

    private bool IsOffscreen()
    {
        if (spriteRenderer.transform.position.y <= -1f)
        if (spriteRenderer.transform.position.y <= -7f)
            return true;
        return false;
    }
}
