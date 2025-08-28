using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractable : MonoBehaviour
{
    private Animator doorAnimator;
    private bool isOpen;

    private void Awake()
    {
        doorAnimator = GetComponent<Animator>();
    }
    public void ToggleDoor()
    {
        isOpen = !isOpen;
        doorAnimator.SetBool("IsOpen",isOpen);
    }
}
