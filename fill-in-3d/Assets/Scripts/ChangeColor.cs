using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Color firstColor;

    private void Start()
    {
        firstColor = gameObject.GetComponent<Renderer>().material.color;

        gameObject.GetComponent<Renderer>().material.color = Color.gray;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("cube"))
        {
            gameObject.GetComponent<Renderer>().material.color = firstColor;

            Destroy(collider.gameObject);
        }
        

    }




}