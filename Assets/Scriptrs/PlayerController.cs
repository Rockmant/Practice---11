using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    private  Rigidbody rb;
    public float controllerPower;
    public  CameraMovement offset;    //выхватываю вектор позиции камеры(OpenDoor не удобно было тестить. улучшаю управление)
    private float horizontal;
    private float vertical;
    
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }
    private void PlayerKeyControl()
    {
        #region реализаци€ через GetKey
        #region Ќахожу проекцию вектора позиции камеры относительно игрока на плоскость XZ и нормализую. Offset1 
        //Vector3 offset1;
        //offset1 = -offset.offset;
        //offset1.y = 0;
        //offset1 = offset1.normalized;
        #endregion

        //if (Input.GetKey(KeyCode.W))
        //{
        //    rb.AddForce(offset1 * controllerPower, ForceMode.VelocityChange);
        //}

        //if (Input.GetKey(KeyCode.S))
        //{
        //    rb.AddForce(-offset1 * controllerPower, ForceMode.VelocityChange);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    offset1.Set(-offset1.z, 0, offset1.x);
        //    rb.AddForce(offset1 * controllerPower, ForceMode.VelocityChange);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    offset1.Set(offset1.z, 0, -offset1.x);
        //    rb.AddForce(offset1 * controllerPower, ForceMode.VelocityChange);

        //}
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    rb.AddForce(Vector3.up * 150, ForceMode.Force); //ј теперь нужно как-то через GetAxis 
        //}
#endregion
        #region через GetAxis
        
        #region Ќахожу проекцию вектора позиции камеры относительно игрока на плоскость XZ и нормализую. Offset1 
        Vector3 offset1;
        offset1 = -offset.offset;
        offset1.y = 0;
        offset1 = offset1.normalized;
        #endregion
        rb.AddForce(offset1*vertical*controllerPower,ForceMode.VelocityChange);
        if (horizontal > 0)
        {
            offset1.Set(offset1.z, 0, -offset1.x);
            rb.AddForce(offset1 * controllerPower*horizontal, ForceMode.VelocityChange);

        }
        if (horizontal < 0)
        {
            offset1.Set(offset1.z, 0, -offset1.x);
            rb.AddForce(offset1 * controllerPower*horizontal, ForceMode.VelocityChange);
        }
        #endregion
    }
    
    void FixedUpdate()
    {
        PlayerKeyControl();
        if (rb.velocity.magnitude < 3) animator.SetBool("speedChanger", false);
        if (rb.velocity.magnitude > 3) animator.SetBool("speedChanger", true);
    }
    private void Update()
    {
         horizontal = Input.GetAxis("Horizontal");
         vertical = Input.GetAxis("Vertical");
         
    }
}
