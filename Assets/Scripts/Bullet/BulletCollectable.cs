using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class BulletCollectable : MonoBehaviour
{
    [SerializeField] private int bullet;

    public int GetBullet()
    {
        return bullet;
    }
}
