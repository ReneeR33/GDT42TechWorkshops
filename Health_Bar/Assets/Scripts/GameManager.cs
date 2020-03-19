using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool gameEnded = false;
    public float restartDelay;
    public float levelCompleteDelay;
    public int score = 0;
    public float timeLeft = 50f;

    public GameObject levelCompleteUI;
    
    private void Update()
    {
        timeLeft -= Time.deltaTime;
        
        if(timeLeft <= 0) Invoke("Restart", restartDelay);
    }
    public void EndGame()
    {
        if (!gameEnded)
        {
            gameEnded = true;
            Invoke("Restart", restartDelay);
        }

    }

    public void LevelComplete()
    {
        levelCompleteUI.SetActive(true);
        Invoke("Restart", levelCompleteDelay);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddScore(int value) 
    { 
        score += value;
    }
}
