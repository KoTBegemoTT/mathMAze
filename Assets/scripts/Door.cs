using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public GameObject exit;
    public bool opened;

    private void OnTriggerEnter(Collider other)
    {
        if (opened)
        {
            GameObject.Find("DoorSound").GetComponent<AudioSource>().Play();
            other.gameObject.SetActive(false);
            other.transform.position = exit.transform.position;
            other.gameObject.SetActive(true);
        }
        else
            GameObject.Find("ClosedDoor").GetComponent<AudioSource>().Play(); 
    }
}
