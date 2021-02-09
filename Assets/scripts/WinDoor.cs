using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDoor : MonoBehaviour
{
    public bool opened;

    private void OnTriggerEnter(Collider other)
    {
        if (opened)
        {
            GameObject.Find("DoorSound").GetComponent<AudioSource>().Play();
            Application.LoadLevel(3);
        }
        else
            GameObject.Find("ClosedDoor").GetComponent<AudioSource>().Play();
    }
}
