using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollison : MonoBehaviour
{
    public PlayerScript playerScript;
    public Score score;
    public GameController gameController;
    public AudioSource audioSource;
    public AudioSource audioSouceGameOver;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectables")
        {
            score.AddScore(1);
            Destroy(other.gameObject);
            audioSource.Play();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="Obstacles")
        { 
            playerScript.enabled = false;
            gameController.GameOver();
            audioSouceGameOver.Play();
        }
    }
}
