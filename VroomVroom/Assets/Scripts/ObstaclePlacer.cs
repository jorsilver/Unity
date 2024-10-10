using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePlacer : MonoBehaviour
{
    public GameObject Prefab2;
    public GameObject Prefab3;
    public GameObject Prefab4;
    protected List<float> lanePositions = new List<float> { -3.5f, 0f, 3.5f };
    protected bool isSpawning = false;
    protected bool isWaitingToCreate = false;
    protected int secondsUntilNextCreation;


    private void Update()
    {
        if (!isWaitingToCreate)
        {
            isWaitingToCreate = true;
            secondsUntilNextCreation = Random.Range(1, 2);
            StartCoroutine(CountdownToCreation());
        }
    }

    IEnumerator CountdownToCreation()
    {
        yield return new WaitForSeconds(secondsUntilNextCreation);
        Create();
    }

    protected virtual void Create()
    {
        isWaitingToCreate = false;
        int lanePosition = Random.Range(0, 3);
        int number = Random.Range(1, 4);
        
        if(number == 1)
        {
            Instantiate(Prefab2, new Vector3(lanePositions[lanePosition], 32f, -.7f), Quaternion.identity);
        }
        if (number == 2)
        {
            Instantiate(Prefab3, new Vector3(lanePositions[lanePosition], 32f, -.7f), Quaternion.identity);
        }
        if (number == 3)
        {
            Instantiate(Prefab4, new Vector3(lanePositions[lanePosition], 32f, -.7f), Quaternion.identity);
        }
        if(number == 1)
        {
            Instantiate(Prefab2, new Vector3(lanePositions[lanePosition], 32f, -.7f), Quaternion.identity);
        }
        if (number == 2)
        {
            Instantiate(Prefab3, new Vector3(lanePositions[lanePosition], 32f, -.7f), Quaternion.identity);
        }
        if (number == 3)
        {
            Instantiate(Prefab4, new Vector3(lanePositions[lanePosition], 32f, -.7f), Quaternion.identity);
        }
    }    

}
