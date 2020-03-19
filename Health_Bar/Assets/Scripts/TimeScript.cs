using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public GameManager manager;
    void Update()
    {
        if (manager.timeLeft >= 0) GetComponent<Text>().text = manager.timeLeft.ToString("0.00");
        else GetComponent<Text>().text = "0.00";
    }
}
