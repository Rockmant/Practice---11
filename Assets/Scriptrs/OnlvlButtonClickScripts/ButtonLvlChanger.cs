using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLvlChanger : MonoBehaviour
{
    public void OnButtonClick()
    {
        switch (gameObject.name)
        {
            case "Lvl1Button":
                SceneManager.LoadScene(1);
                break;

            case "Lvl2Button":
                SceneManager.LoadScene(2);
                break;
            case "Lvl3Button":
                SceneManager.LoadScene(3);
                break;
            case "Lvl4Button":
                SceneManager.LoadScene(4);
                break;
            case "BackToMainMenuButton":
                SceneManager.LoadScene(0);
                break;

        }


    }
}
