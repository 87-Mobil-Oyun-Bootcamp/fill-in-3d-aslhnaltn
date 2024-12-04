using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    Vector3 pos;
    Vector3 dir;
    float angle;

    private void Start()
    {

        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit) && Input.GetMouseButton(0))
        {
            transform.position = Vector3.Lerp(transform.position, hit.point, 0.1f);

            pos = Camera.main.WorldToScreenPoint(transform.position);

            dir = Input.mousePosition - pos;

            angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

            transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
        }
      
    }
 
}

