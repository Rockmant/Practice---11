using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class PlatformBehavior : MonoBehaviour
{
    private Animator anim;

    private void ChangeAnimation()
    {
        System.Random rnd = new System.Random();
        int n;
        n = rnd.Next(0, 3);
        anim.SetInteger("anim1", n);



    }


    void Start()
    {
        anim = GetComponent<Animator>();

    }



}
