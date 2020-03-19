using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryScript : MonoBehaviour
{
    public GameObject PrefabRoad;
    public Transform StartPos;
    public float TimeBetweenSpawns;

    private int nextStep = 0;

    private void Start()
    {
        StartCoroutine(CoroutineStart());
    }
    IEnumerator CoroutineStart()
    {
        while (true)
        {
            SpawnNext();
            yield return new WaitForSeconds(TimeBetweenSpawns);
        }
    }
    public void SpawnNext()
    {
        nextStep += 25;
        Instantiate(PrefabRoad, new Vector3(StartPos.position.x, StartPos.position.y, transform.position.z + nextStep), Quaternion.identity);
        Debug.Log("Yes");
    }
}
