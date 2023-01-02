using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void exit()
    {
        Application.Quit();
    }

}
