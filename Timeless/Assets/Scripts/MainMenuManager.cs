using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Salir();
        }
    }

    public void Salir()
    {
        Application.Quit();
    }
}
