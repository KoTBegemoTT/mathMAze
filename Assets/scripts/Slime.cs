using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    public GameObject phrase;
    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            phrase.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        phrase.SetActive(false);
    }
}
