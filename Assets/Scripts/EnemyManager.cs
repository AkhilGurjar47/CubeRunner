using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager Instance {  get; private set; } 
    public List<Transform> enemyGroupTransform = new List<Transform>();
    public List<int> enemyCount = new List<int>();
    private int finish;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    private void Start()
    {
        Debug.Log(enemyGroupTransform.Count);
        for (int i = 0; i < enemyGroupTransform.Count; i++)
        {
            enemyCount.Add(enemyGroupTransform[i].childCount);
        }
    }
    public void EnemyGroupCheck()
    {
        finish++;
        for(int i = 0; i< enemyCount.Count;i++)
        {
            if(enemyCount[i] == finish)
            {
                finish = 0;
            }
            else
            {
                break;
            }
        }
    }
}
