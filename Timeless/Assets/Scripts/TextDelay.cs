using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDelay : MonoBehaviour
{
    public Image image; // Asegúrate de asignar tu imagen en el editor de Unity
    public float fadeDuration = 1.0f;
    public float delay = 3.0f;

    void Start()
    {
        image.canvasRenderer.SetAlpha(0.0f); // Configura la opacidad inicial a 0
        Invoke("FadeIn", delay); // Invoca el método FadeIn después del retraso especificado
    }

    void FadeIn()
    {
        image.CrossFadeAlpha(1.0f, fadeDuration, false); // Hace el fade-in de la imagen
    }
}
