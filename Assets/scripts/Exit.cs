using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject came1;
    public GameObject came2;

    private void OnTriggerEnter(Collider other)
    {
        came1.SetActive(false);
        came2.SetActive(true);
    }

}
