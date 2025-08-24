using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject enemyBullet;
    public Transform enemyBulletSpawnPoint;
    public PlayerScript playerScript;
    public int maxHealth = 100;
    public int currentHealth;

    private float maxX = 4.45f;
    private float minX = -4.45f;
    private float Timer;
    private bool leftPositionIsTure;
    // Start is called before the first frame update

    private void Awake()
    {
       
    }
    void Start()
    {
        Timer = 3;
        currentHealth = maxHealth;
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 enemyPosition = transform.position;
        enemyPosition.x = Mathf.Clamp(enemyPosition.x,minX,maxX);
        transform.position = enemyPosition; 
        if(playerScript.stopLine)
        {
            Timer += Time.deltaTime;
            if (Timer > 2)
            {
                GameObject bullet = Instantiate(enemyBullet, enemyBulletSpawnPoint.position, Quaternion.identity);
                bullet.GetComponent<Rigidbody>().velocity = -enemyBulletSpawnPoint.forward * 20;
                Timer = 0;
            }
        }
        if (!leftPositionIsTure)
        {
            transform.position = transform.position - new Vector3(2f * Time.deltaTime, 0, 0);
            if(-4 > transform.position.x)
            {
                leftPositionIsTure = true;
            }
        }
        else
        {
            transform.position = transform.position + new Vector3(2f * Time.deltaTime, 0, 0);
            if (4 < transform.position.x)
            {
                leftPositionIsTure= false;
            }
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("damage" + damage +"" +currentHealth );
    }
}
