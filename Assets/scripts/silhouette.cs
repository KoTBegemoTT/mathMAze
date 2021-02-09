using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class silhouette : MonoBehaviour
{
    public GameObject sil;
    public GameObject part1;
    public GameObject part2;
    public GameObject part3;
    public GameObject part4;
    // Start is called before the first frame update

    public void Click()
    {
        sil.SetActive(false);
        part1.SetActive(false);
        part2.SetActive(false);
        part3.SetActive(false);
        part4.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
