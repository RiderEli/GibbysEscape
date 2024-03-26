using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialScreen : MonoBehaviour
{
    public void TotheTutorial()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void NextScreen()
    {

    }

    public void PrevScreen()
    {

    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
