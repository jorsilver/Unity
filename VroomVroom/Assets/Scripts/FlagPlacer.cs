using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagPlacer : MonoBehaviour
{
    public RoadMover RoadMover;
    public CountDownTimer CountDownTimer;
    public LevelCompleteActions LevelCompleteActions;

    public GameObject LevelFlag;
    
    public bool CanCheck = true;
    public int secondsUntilNextCheck = 2;
    public int level = 1;

    public Quaternion Orientation = Quaternion.Euler(-26f, 0f, 0f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (CanCheck == true)
        {
            if (RoadMover.RoadDistance >= 12)
                CheckReady();
        }
    }

    public void CheckReady()
    {
        if (RoadMover.RoadDistance % 12 == 0)
        {
            print("flag");
            level += 1;
            make();
            CanCheck = false;
            LevelCompleteActions.LevelModifier();
            StartCoroutine(WaitToCheck());
        }
    }

    IEnumerator WaitToCheck()
    {
        yield return new WaitForSeconds(secondsUntilNextCheck);
        CanCheck = true;
    }


    public void make()
    {
        if (level < 6)
        {
            print("Level" + level);
            Instantiate(LevelFlag, new Vector3(10f, 38f, 0f), Orientation);
        }
    }
}