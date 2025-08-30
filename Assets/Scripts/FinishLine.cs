using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private ParticleSystem particle1;
    [SerializeField] private ParticleSystem particle2;

    private void Awake()
    {
        particle1.Stop();
        particle2.Stop();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<PlayerScript>() != null)
        {
            particle1.Play();
            particle2.Play();
        }
    }
}
