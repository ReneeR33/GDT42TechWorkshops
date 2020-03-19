using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameManager manager;
    void Update()
    {
        GetComponent<Text>().text = manager.score.ToString();
    }
}
