using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public new Rigidbody rigidbody;
    public float force = 1000f;
    public float speed = 10f;
    public float maxX=4.45f;
    public float minX=-4.45f;
    public GameObject bullet;
    public Transform bulletSpawnPoint;
    public bool endPoint;
    void Start()
    {
        
    }
    void Update()
    {
        Vector3 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, minX, maxX);
        transform.position = playerPos;
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            endPoint = true;
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.S) && endPoint)
        {
            Shoot();
        }
    }
    private void FixedUpdate()
    {
        rigidbody.AddForce(0, 0, force * Time.deltaTime);
    }
    private void Shoot()
    {
        GameObject Bullet = Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
        Bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * 20;
    }
}
