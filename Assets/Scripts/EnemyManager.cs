using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager Instance {  get; private set; } 
    public List<Transform> enemyGroupTrasnform = new List<Transform>();
    public Door door;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    public void EnemyGroupCheck()
    {
        foreach (Transform t in enemyGroupTrasnform)
        {
            Debug.Log(t.childCount);
            if (t.childCount == 0)
            {
                Debug.Log("Group 1 is Destroyed");
                door.DoorOpen();
            }
        }
    }
}
