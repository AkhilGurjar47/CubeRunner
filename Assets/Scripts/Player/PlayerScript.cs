using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public static PlayerScript Instance { get; private set; }
    public new Rigidbody rigidbody;
    public float force = 1000f;
    public float speed = 10f;
    public float maxX=4.45f;
    public float minX=-4.45f;
    public GameObject bullet;
    public Transform bulletSpawnPoint;
    public bool stopLine;
    public BulletText bulletText;
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    private PlayerCollison playerCollison;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        Application.targetFrameRate = 20;
        playerCollison = GetComponent<PlayerCollison>();
    }
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    void Update()
    {
        
        Vector3 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, minX, maxX);
        transform.position = playerPos;
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S) && stopLine && bulletText.bullet != 0)
        {
            bulletText.bullet--;
            Shoot();
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            TakeDamage(20);
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if(currentHealth <= 0)
        {
            playerCollison.GameOver();
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
        if (!stopLine)
        {
            rigidbody.AddForce(0, 0, force * Time.deltaTime);
        }
    }
    private void Shoot()
    {
        GameObject Bullet = Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
        Bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * 20;
    }
    public void Finish()
    {
        stopLine = true;
    }
    public void EnemyIsDestroyed()
    {
        stopLine = false;
    }
}
