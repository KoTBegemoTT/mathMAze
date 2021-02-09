using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightTriger : MonoBehaviour
{
    public string answer;
    public GameObject task;
    public GameObject imputField;
    public GameObject door1;
    public GameObject door2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<Animator>().SetInteger("State", 0);
            other.GetComponent<Hero>().enabled = false;
            task.SetActive(true);
            imputField.SetActive(true);
        }
        imputField.GetComponent<TextEnter>().enemy = gameObject.transform.parent.gameObject;
        imputField.GetComponent<TextEnter>().answer = answer;
        imputField.GetComponent<TextEnter>().task = task;

    }

    public void OnDestroy()
    {
        if (door1 != null)
            door1.GetComponent<Door>().opened = true;
        if (door2 != null)
            door2.GetComponent<Door>().opened = true;
    }
}
