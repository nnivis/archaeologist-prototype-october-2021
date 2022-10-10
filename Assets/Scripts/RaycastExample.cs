using UnityEngine;
using System.Collections;

public class RaycastExample : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

    void Update()
    {
        //Be sure to have a main camera that is tagged "MainCamera" for this example to work.
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            //Left Click, change to red.
            if (Input.GetMouseButtonDown(0))
            {
                hit.collider.GetComponent<Renderer>().material.color = Color.red;
            }

            //Right Click, change to blue.
            if (Input.GetMouseButtonDown(1))
            {
                hit.collider.GetComponent<Renderer>().material.color = Color.blue;
            }
        }
    }
}