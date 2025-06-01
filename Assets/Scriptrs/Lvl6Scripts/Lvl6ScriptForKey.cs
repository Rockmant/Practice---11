using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl6ScriptForKey : MonoBehaviour
{
    [SerializeField] private ParticleSystem particle;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            particle.Play();
           Destroy(this.gameObject);
        }
    }
   
}
