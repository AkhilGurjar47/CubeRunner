using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollectable : MonoBehaviour
{
    private float life = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, life);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
