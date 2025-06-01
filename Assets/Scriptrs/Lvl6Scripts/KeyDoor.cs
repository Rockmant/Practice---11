using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class KeyDoor : MonoBehaviour
{
    public GameObject text;
    private bool canOpen = false;
    private Animator animator;
    public Lvl6ScriptForKey haveKey;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text.SetActive(true);
            if (haveKey == null)
            {
                canOpen = true;
            }

            #region commentary
            //if (animator.GetBool("doorOpened")==false){
            //    if (Input.GetKeyDown(KeyCode.F))               // ������� ������ �������� ����������� (������ �� �����������) ������? �������������� ������� OnTriggerStay
            //    { 
            //        animator.SetBool("doorOpened", true);
            //    }
            //}
            //if (animator.GetBool("doorOpened")==true){
            //    if (Input.GetKeyDown(KeyCode.F))
            //    {

            //        animator.SetBool("doorOpened", false);


            //    }
            //}
            #endregion
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text.SetActive(false);
            animator.SetBool("doorOpened", false);
            canOpen = false;
        }
    }
    void Start()
    {
        animator = GetComponent<Animator>();
        text = GameObject.Find("PressF");
        text.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F) && canOpen)  //��� �������� ������ �������� ��, OnTriggerStay �������� �����������.        
        {
            animator.SetBool("doorOpened", true);
        }
    }
}

