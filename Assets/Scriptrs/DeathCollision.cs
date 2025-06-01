using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCollision : MonoBehaviour
{
    [SerializeField] private ParticleSystem deathBurst;
    [SerializeField] private GameObject player;
   
    private IEnumerator TimerToPlayBurst()
    {
        player.SetActive(false);
        
            deathBurst.Play();
           
        yield return new WaitForSeconds(5);
        Debug.Log("time");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.CompareTag("Player"))
        {
           StartCoroutine(TimerToPlayBurst());
           
        }
    }
}
