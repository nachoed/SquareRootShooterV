using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{

    public GameObject buttons;
    public GameObject credits;

   public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void CreditsButton()
    {
        buttons.SetActive(false);
        credits.SetActive(true);
    }

    public void BackToMenu()
    {
        buttons.SetActive(true);
        credits.SetActive(false);
    }

}
