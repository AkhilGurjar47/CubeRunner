using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager Instance {  get; private set; } 
    public List<Transform> enemyGroupTransform = new List<Transform>();
    public List<Transform> interactableTransform = new List<Transform>();
    public List<int> enemyCount = new List<int>();
    private int finishCount;
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
        while (finishCount < enemyCount.Count)
        {
            if (enemyCount[finishCount] == finish)
            {
                finish = 0;
                interactableTransform[finishCount].GetComponent<DoorInteractable>().ToggleDoor();
                PlayerScript.Instance.EnemyIsDestroyed();
                finishCount++;
            }
            else
            {
                break;
            }
        }
    }
}
