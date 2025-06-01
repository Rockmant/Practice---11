using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEaterScript : MonoBehaviour
{
    public static int destroyCount;
    public GameObject bridge;
   void Start()
    {
        destroyCount = 0;
    }
    private void BridgeReveal() {
        if (destroyCount == 3)
        {
            bridge.SetActive(true);
            destroyCount = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.name == "CubeItem" && this.name == "CubeEater") || (other.gameObject.name == "CylinderItem" && this.name == "CylinderEater")
                || (other.gameObject.name == "SphereItem" && this.name == "SphereEater"))
        {
           
            Destroy(other.gameObject);
            destroyCount++;
            BridgeReveal();
            Debug.Log(destroyCount);
            Destroy(this.gameObject);

        }
        

    }

}
