using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KeyboardScript3 : MonoBehaviour
{
    public Image image;
    public Image image2;
    public Image image3;
    public Image image4;
    public Canvas makeAChoice;
    public float fadeDuration = 1.0f;
    public float delay = 1.0f;

    void Start()
    {
        makeAChoice.enabled = false;
        Invoke("FadeIn", delay);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            image.CrossFadeAlpha(0.0f, fadeDuration, false);
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            image2.CrossFadeAlpha(0.0f, fadeDuration, false);
            makeAChoice.enabled = !makeAChoice.enabled;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            SceneManager.LoadScene(4);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene(5);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene(5);
        }
    }
}
