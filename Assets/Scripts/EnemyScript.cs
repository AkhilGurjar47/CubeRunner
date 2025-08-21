using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject enemyBullet;
    public Transform enemyBulletSpawnPoint;
    private float Timer;
    public PlayerScript playerScript;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(playerScript.endPoint)
        {
            Timer += Time.deltaTime;
            if (Timer > 2)
            {
                GameObject bullet = Instantiate(enemyBullet, enemyBulletSpawnPoint.position, Quaternion.identity);
                bullet.GetComponent<Rigidbody>().velocity = -enemyBulletSpawnPoint.forward * 20;
                Timer = 0;
            }
        } 
        transform.position = transform.position - new Vector3(0.1f * Time.deltaTime, 0, 0);
    }
}
