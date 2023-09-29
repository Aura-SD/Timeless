using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    private bool movimientoBloqueado = false;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Start()
    {
        DesbloquearMovimiento(); // Empieza desbloqueado
    }

    void Update()
    {
        if (!movimientoBloqueado)
        {
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (movimientoBloqueado)
            {
                DesbloquearMovimiento();
            }
            else
            {
                BloquearMovimiento();
            }
        }
    }

    void BloquearMovimiento()
    {
        movimientoBloqueado = true;
    }

    void DesbloquearMovimiento()
    {
        movimientoBloqueado = false;
    }
}
