using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextEnter : MonoBehaviour 
{
    public GameObject winDoor;
    public GameObject hero;
    public GameObject task;
    public GameObject enemy;
    public string answer;
    public TMP_InputField t;
    public GameObject silhouette;
    public GameObject part1;
    public GameObject part2;
    public GameObject part3;
    public GameObject part4;

    private LivesBar livesBar;

    private void Awake()
    {
        livesBar =  FindObjectOfType<LivesBar>();
    }

    public void EndEdit()
    {
        var a = t.text;
        if (a == answer)
        {
            if (a == "15.87")
            {
                winDoor.GetComponent<WinDoor>().opened = true;
                variable.part4 = true;
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
            variable.defitedCount++;
            Destroy(enemy);
            Destroy(task);
        }
        else
        {
            GameObject.Find("MobPunch").GetComponent<AudioSource>().Play();
            variable.lives--;
            livesBar.Refresh();
            task.SetActive(false);
        }
        t.text = string.Empty;
        gameObject.SetActive(false);
        hero.GetComponent<Hero>().enabled = true;
    }
}