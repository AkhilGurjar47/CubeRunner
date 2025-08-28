using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollison : MonoBehaviour
{
    public PlayerScript playerScript;
    public Score score;
    public BulletText bulletText;
    public GameController gameController;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectables")
        {
            if(other.gameObject.GetComponent<Coin>() != null)
            {
                Destroy(other.gameObject);
                audioSource.Play();
            }
            if(other.gameObject.GetComponent<BulletCollectable>() != null)
            {
                bulletText.AddBullet();
                Destroy(other.gameObject);
                audioSource.Play();
            }
            else
            {
                score.AddScore(1);
                Destroy(other.gameObject);
                audioSource.Play();
            }
        }
        if(other.gameObject.tag == "Finish")
        {
            playerScript.Finish();
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="Obstacles")
        { 
            playerScript.enabled = false;
            gameController.GameOver();
            //audioSouceGameOver.Play();
        }
    }
    public void GameOver()
    {
        gameController.GameOver();
    }
}
