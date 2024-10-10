using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    public Text TotalTime;
    public Text LevelCountDown;
    public Text Lives;
    public Text GameOver;
    public Text Win;

    public void ShowTotalTime(float totalTime)
    {
        TotalTime.text = "Score: " + Mathf.Round(totalTime);
    }

    public void ShowLevelTime(float levelTime)
    {
        LevelCountDown.text = "Level Time: " + Mathf.Round(levelTime);
    }

    public void ShowLives(float lives)
    {
        Lives.text = "Lives: " + lives;
    }
    
    public void ShowGameOver()
    {
        GameOver.text = "Game Over";
    }

    public void ShowWin()
    {
        Win.text = "You Won !";
    }
}
