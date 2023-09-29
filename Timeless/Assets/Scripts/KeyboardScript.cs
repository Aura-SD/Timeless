using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KeyboardScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && IsMouseOverCollider())
        {
            SceneManager.LoadScene(2);
        }

    }

    bool IsMouseOverCollider()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        return Physics.Raycast(ray, out hit) && hit.collider != null && hit.collider.gameObject == gameObject;
    }

}
