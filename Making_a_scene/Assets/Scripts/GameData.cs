using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New GameData File", menuName = "GameData File")]
public class GameData : ScriptableObject
{
    public string playerOneName;
    public string playerTwoName;

    public int rounds;
}
