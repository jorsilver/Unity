using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTimedObjectPlacer : MonoBehaviour
{
    public GameObject Prefab;
    public Camera Camera;

    public int MinimumTimeToCreation = 1;
    public int MaximumTimeToCreation = 3;

    public bool isWaitingToCreate = false;
    private int secondsUntilCreation;

    // Start is called before the first frame update
    public virtual void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!isWaitingToCreate)
        {
            isWaitingToCreate = true;
            secondsUntilCreation = Random.Range(MinimumTimeToCreation,
                MaximumTimeToCreation + 1);
            StartCoroutine(CountdownUntilCreation());
        }
    }
    IEnumerator CountdownUntilCreation()
    {
        yield return new WaitForSeconds(secondsUntilCreation);
        Create();
    }
    public virtual void Create()
    {
        isWaitingToCreate = false;
    }
}
