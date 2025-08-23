using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    private Transform Door1;
    [SerializeField]
    private Transform Door2;
    
    public void DoorOpen()
    {
        Door1.Translate(1,0,0);
        Door2.Translate(-1,0,0);
    }
}
