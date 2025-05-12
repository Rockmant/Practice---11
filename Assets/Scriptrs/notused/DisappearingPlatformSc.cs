using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Unity.VisualScripting;

public class DisappearingPlatformSc : MonoBehaviour
{
    public float disappearingTime;
    
    private IEnumerator timer()
    {
        yield return new WaitForSeconds(disappearingTime);
        Destroy(this.gameObject, 0f);
    }
    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) StartCoroutine(timer()); 
     
    }
    void Update()
    {
        
    }
}
