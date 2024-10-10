using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public CountDownTimer CountDownTimer;

    public GameObject car;
    public GameObject road1;
    public GameObject road2;
    public GameObject road3;
    public GameObject display;
    public GameObject endScreen;
    public GameObject timer;

    public Text FinalScore;

    void Start()
    {
        endScreen.SetActive(false);
        display.SetActive(true);
        timer.SetActive(true);
        car.SetActive(true);
        road1.SetActive(true);
        road2.SetActive(true);
        road3.SetActive(true);
    }

    public void LoseGame(float finalScore)
    {
        timer.SetActive(false);
        car.SetActive(false);
        road1.SetActive(false);
        road2.SetActive(false);
        road3.SetActive(false);
        display.SetActive(false);
        endScreen.SetActive(true);
        FinalScore.text = "Final Score: " + Mathf.Round(finalScore);
    }
}
