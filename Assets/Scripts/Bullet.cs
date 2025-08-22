using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float life = 3f;
    private bool enemyIsDestroy;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,life);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            PlayerScript.Instance.EnemyIsDestroyed();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if(collision.gameObject.tag != "Ground")
            Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
