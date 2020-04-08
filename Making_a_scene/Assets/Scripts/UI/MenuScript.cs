using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuScript : MonoBehaviour
{
    public GameData GameDataFile;
    
    public TMP_InputField InputFieldPlayerOne;
    public TMP_InputField InputFieldPlayerTwo;
    
    public void StartGame()
    {
        if(InputFieldPlayerOne.text != "" && InputFieldPlayerTwo.text != "")
        {
            GameDataFile.playerOneName = InputFieldPlayerOne.text;
            GameDataFile.playerTwoName = InputFieldPlayerTwo.name;
            SceneManager.LoadScene(1);
        }
       
    }
}
