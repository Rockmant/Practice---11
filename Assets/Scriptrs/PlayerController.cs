using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class PlayerController : MonoBehaviour
{
    private Animator animator;
  private  Rigidbody rb;
    public float controllerPower;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }
    private void PlayerKeyControl()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * controllerPower, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(Vector3.back * controllerPower, ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Vector3.left * controllerPower, ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(Vector3.right * controllerPower, ForceMode.VelocityChange);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 150, ForceMode.Force);
        }
    }
    // Update is called once per frame
    void Update()
    {
        PlayerKeyControl();
        if (rb.velocity.magnitude < 5) animator.SetBool("speedChanger", false);
        if (rb.velocity.magnitude > 5) animator.SetBool("speedChanger", true);
    }
}
