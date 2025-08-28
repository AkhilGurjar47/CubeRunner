using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private float life = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, life);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerScript>().TakeDamage(20);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag != "Ground" && collision.gameObject.tag != "enemy")
            Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
