using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    private bool movimientoBloqueado = false;

    void Start()
    {
        DesbloquearMovimiento(); // Empieza desbloqueado
    }

    void Update()
    {
        if (!movimientoBloqueado)
        {
            float movimientoHorizontal = Input.GetAxis("Horizontal");
            float movimientoVertical = Input.GetAxis("Vertical");

            Transform camaraTransform = Camera.main.transform;

            Vector3 movimiento = (camaraTransform.right * movimientoHorizontal + camaraTransform.forward * movimientoVertical).normalized;
            movimiento.y = 0;

            movimiento = movimiento.normalized * velocidadMovimiento * Time.deltaTime;

            transform.Translate(movimiento, Space.World);
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
