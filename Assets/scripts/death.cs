using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    public GameObject hero;
    public void Awake()
    {
        hero.GetComponent<Animator>().SetInteger("State", 1);
    }
}
