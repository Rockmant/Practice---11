using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingTrigger : MonoBehaviour
{
    public float disappearingTime;

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(disappearingTime);
        Destroy(this.gameObject, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item")) StartCoroutine(Timer());

    }
    
}
