using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public SpriteRenderer PlayerSprite;
    public Rigidbody PlayerRigidBody;
    public CountDownTimer timer;
    public Display Display;
    public EndGame EndGame;

    public Sprite CarAfterOneLifeLost;
    public Sprite CarAfterTwoLivesLost;
    public Sprite CarAfterAllLivesLost;

    private int laneNumber = 2;

    public bool LifeLost = false;
    public bool SecondLifeLost = false;
    public bool LastLife = false;
    private bool isJumping;

    public Text GameResult;

    private List<float> laneXPositions = new List<float> { -3.5f, 0f, 3.5f };
    
    void Start()
    {
        Physics.gravity = new Vector3(0f, 0f, 9.8f);
    }

    public void Jump()
    {
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            print("jump");
            PlayerRigidBody.AddForce(new Vector3(0f, 0f, GameParameters.jumpForce), ForceMode.Impulse);
            isJumping = true;
        }
    }

    public void LoseLife()
    {
        LifeLost = true;
        PlayerSprite.sprite = CarAfterOneLifeLost;
        LifeLost = false;
    }

    public void LoseAnotherLife()
    {
        SecondLifeLost = true;
        PlayerSprite.sprite = CarAfterTwoLivesLost;
        SecondLifeLost = false;
    }

    public void LoseLastLife()
    {
        LastLife = true;
        PlayerSprite.sprite = CarAfterAllLivesLost;
        LastLife = false;
    }
    
    public void ShowLoseResults()
    {
        GameResult.text = "GAME OVER";
    }

    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Obstacle1")
        { 
            Mover.SlowDown();
            Destroy(col.gameObject);
        }
        
        if (col.gameObject.tag == "Ground")
        {
            isJumping = false;
            Jump();
        }
    }

    public void MoveLeft()
    {
        laneNumber = laneNumber - 1;
        if (laneNumber < 1)
            laneNumber = 1;
        PlayerSprite.transform.position = new Vector3(
            laneXPositions[laneNumber - 1], PlayerSprite.transform.position.y,
            PlayerSprite.transform.position.z);
    }

    public void MoveRight()
    {
        laneNumber = laneNumber + 1;
        if (laneNumber > 3)
            laneNumber = 3;
        PlayerSprite.transform.position = new Vector3(
            laneXPositions[laneNumber - 1], PlayerSprite.transform.position.y,
            PlayerSprite.transform.position.z);
    }
}
