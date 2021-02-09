using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    CharacterController MyPawnBody;
    Animator anim;
    SpriteRenderer rend;
    public float speed = 6.0F;

    Vector2 moveDerection = Vector2.zero;
    void Start()
    {
        MyPawnBody = this.GetComponent<CharacterController>();
        anim = this.GetComponent<Animator>();
        rend = this.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
        if (MyPawnBody != null)
        {
            float AD = Input.GetAxis("Horizontal");
            float MS = Input.GetAxis("Vertical");
            if (AD != 0 || MS != 0)
            {
                if (AD <= 0)
                    rend.flipX = true;
                else rend.flipX = false;
                anim.SetInteger("State", 1);
            }
            else anim.SetInteger("State", 0);
            moveDerection = new Vector3(AD, MS);

            moveDerection = transform.TransformDirection(moveDerection);

            moveDerection *= speed;

            MyPawnBody.Move(moveDerection * Time.deltaTime);
        }
    }
}