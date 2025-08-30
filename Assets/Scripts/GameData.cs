using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int coin;
    
    public GameData(Score score)
    {
        coin = score.MyScore;
    }
}
