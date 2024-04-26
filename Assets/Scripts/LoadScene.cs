using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void MenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void InstructionsButton()
    {
        SceneManager.LoadScene(4);
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void GameOver()
    {
        SceneManager.LoadScene(2);
    }

    public void Victory()
    {
        SceneManager.LoadScene(3);
    }
}
