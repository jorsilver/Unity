using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    public Camera Camera;
    public Display Display;
    public Player Player;
    public EndGame EndGame;
    public KeyboardInput KeyboardInput;

    private bool isGameStarted = false;
    private bool isCountdownStarted = false; 
    private float levelTimeToComplete = GameParameters.TimeToCompleteLevel; 
    private float totalTimePlayed = 0;
    private float levelTime = 0;
    private float scoreMultiplier = 1f;
   
    void Start()
    {
        StartGame();
        Display.ShowLives(3);
    }

    void Update()
    {
        if (GameParameters.lives == -2 || Mover.speed >= -.0001f)
            EndGame.LoseGame(totalTimePlayed);
    }

    void FixedUpdate()
    {
        print(Mover.speed);
        if (isGameStarted)
        {
            totalTimePlayed = (totalTimePlayed + Time.fixedDeltaTime) * scoreMultiplier;
            Display.ShowTotalTime(totalTimePlayed);
        }
        else
        {
            Display.ShowTotalTime(0.0f);
        }

        if (!isCountdownStarted)
        {
            levelTime = levelTimeToComplete;
            isCountdownStarted = true;
            StartCoroutine(CountdownUntilLevelCompleted());
        }
        else
        {
            levelTime = levelTime - Time.fixedDeltaTime;
            Display.ShowLevelTime(levelTime);
        }
    }

    IEnumerator CountdownUntilLevelCompleted()
    {
        yield return new WaitForSeconds(levelTimeToComplete);

        GameParameters.lives = GameParameters.lives - 1;
        if (GameParameters.lives == 2)
        {
            Player.LoseLife();
            GameParameters.lives = GameParameters.lives - 1;
            Display.ShowLives(2);
        }
        else if (GameParameters.lives == 0)
        {
            Player.LoseAnotherLife();
            Display.ShowLives(1);

        }
        else if (GameParameters.lives == -2)
        {
            Player.LoseLastLife();
            Display.ShowLives(0);
        }
    }

    public void CountdownReset()
    {
        isCountdownStarted = false;
        ReduceLevelTime();
    }

    public void StartGame()
    {
        isGameStarted = true;
    }

    public void ReduceLevelTime()
    {
        levelTimeToComplete -= GameParameters.TimeToDeincrementLevel;
    }

    public void ScoreMultiplierIncreaser()
    {
        scoreMultiplier += .0015f;
    }
}