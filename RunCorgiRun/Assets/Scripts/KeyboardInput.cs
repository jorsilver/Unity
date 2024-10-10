using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    public Corgi Corgi;
    public PoopPlacer PoopPlacer;

    void Update()
    {
        // check keys
        if (Input.GetKey(KeyCode.W))
        {
            // move corgi up
            Corgi.MoveWithKeyboard(new Vector2(0, 1));
        }
        if (Input.GetKey(KeyCode.A))
        {
            // move corgi left
            Corgi.MoveWithKeyboard(new Vector2(-1, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            // move corgi down
            Corgi.MoveWithKeyboard(new Vector2(0, -1));
        }
        if (Input.GetKey(KeyCode.D))
        {
            // move corgi right
            Corgi.MoveWithKeyboard(new Vector2(1, 0));
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PoopPlacer.Place(Corgi.transform.position);
           
        }
    }
}
