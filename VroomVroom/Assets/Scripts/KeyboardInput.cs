using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    public Player Player;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Player.MoveLeft();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Player.MoveRight();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Player.Jump();
        }
    }
}

