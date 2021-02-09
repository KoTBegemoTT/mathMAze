using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    private bool isFirstTime = true;
    public int chestNumber;
    public GameObject silhouette;
    public GameObject part1;
    public GameObject part2;
    public GameObject part3;
    public GameObject part4;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject.Find("OpenChest").GetComponent<AudioSource>().Play();
            if (isFirstTime)
            {
                isFirstTime = false;
                variable.lives++;
                var bar = FindObjectOfType<LivesBar>();
                bar.Refresh();
            }
            switch (chestNumber)
            {
                case 1:
                    variable.part1 = true;
                    break;
                case 2:
                    variable.part2 = true;
                    break;
                default:
                    variable.part3 = true;
                    break;
            }
            silhouette.SetActive(true);
            if (variable.part1)
                part1.SetActive(true);
            if (variable.part2)
                part2.SetActive(true);
            if (variable.part3)
                part3.SetActive(true);
            if (variable.part4)
                part4.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject.Find("ClozeChest").GetComponent<AudioSource>().Play();
        silhouette.SetActive(false);
        part1.SetActive(false);
        part2.SetActive(false);
        part3.SetActive(false);
        part4.SetActive(false);
    }
}
