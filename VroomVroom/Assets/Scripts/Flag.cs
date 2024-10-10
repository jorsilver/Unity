using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{

    public SpriteRenderer CheckPointFlag;


    void Update()
    {
        Mover.Move(CheckPointFlag);
        if (Mover.IsOffScreen(CheckPointFlag, -5f))
        Destroy(GameObject);

        //transform.position = Vector3.MoveTowards(transform.position, new Vector3(10f, -5f, 0f), Time.deltaTime * speed);
        //if (IsOffscreen())
        //    Destroy(gameObject);
    }

    //private bool IsOffscreen()
    //{
    //    if (spriteRenderer.transform.position.y <= -5f)
    //        return true;
    //    else
    //        return false;
    //}



}


