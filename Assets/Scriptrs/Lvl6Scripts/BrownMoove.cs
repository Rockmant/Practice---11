using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Random =System.Random;

public class BrownMoove : MonoBehaviour
{
  private readonly Random rnd = new();
    private Vector3 rndVector;
    private Rigidbody rb;
    private bool change;
    

    private IEnumerator Brown()
    {
        change = false;

        yield return new WaitForSeconds(1f);
        rndVector.Set(rnd.Next(-1000,1000)/100, 0, rnd.Next(-1000, 1000) / 100);
        rb.AddForce(rndVector, ForceMode.Impulse);
        change = true;
        
    }
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(Brown());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (change)
       StartCoroutine(Brown()); 
    }
}
