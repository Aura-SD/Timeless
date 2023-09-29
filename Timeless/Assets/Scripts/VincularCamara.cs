using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VincularCamara : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public Transform objetoAVincular;

    void Update()
    {
        if (objetoAVincular != null)
        {
            transform.position = objetoAVincular.position;
        }
    }
}
