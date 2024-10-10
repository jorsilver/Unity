using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMover : MonoBehaviour
{
    public SpriteRenderer Road1;
    public SpriteRenderer Road2;
    public SpriteRenderer Road3;
    public int RoadDistance = 0;

   

    // Update is called once per frame
    void Update()
    {
        Mover.Move(Road1);
        Mover.Move(Road2);
        Mover.Move(Road3);
        if (IsOffScreen(Road1))
            MoveToTop(Road1);
        if (IsOffScreen(Road2))
            MoveToTop(Road2);
        if (IsOffScreen(Road3))
            MoveToTop(Road3);
    }

    private bool IsOffScreen(SpriteRenderer spriteRenderer)
    {
        if (spriteRenderer.transform.position.y <= -7.5)
            return true;
        return false;
    }

    private void MoveToTop(SpriteRenderer spriteRenderer)
    {
        spriteRenderer.transform.position = new Vector3(spriteRenderer.transform.position.x, 37.35f,
            spriteRenderer.transform.position.z);
        RoadDistanceTracker();
    }

    public int RoadDistanceTracker()
    {
        RoadDistance += 1;
        return RoadDistance;
    }
}
