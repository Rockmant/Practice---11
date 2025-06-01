using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    private bool canTake = false;
    public GameObject text;
    public Transform item;
    public Transform player;

    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text.SetActive(true);
            canTake = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text.SetActive(false);
            canTake = false;
        }
    } 
    
    
        void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && canTake)
        {
            item.SetParent(player);
            item.rotation = player.rotation;

            


           // item.position = player.position;

        }
    }
}
