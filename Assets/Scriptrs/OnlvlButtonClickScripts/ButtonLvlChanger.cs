using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLvlChanger : MonoBehaviour
{
    public int sceneIndex;
    public void OnButtonClick()
    {
        SceneManager.LoadScene(sceneIndex);


    }
}
