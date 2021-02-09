using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDeath : MonoBehaviour
{
    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = this.GetComponent<Animator>();
        anim.SetInteger("State", 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}