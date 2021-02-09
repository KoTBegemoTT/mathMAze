using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    public GameObject book;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            book.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        book.SetActive(false);
    }
}
