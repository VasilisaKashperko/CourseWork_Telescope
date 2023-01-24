using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript : MonoBehaviour
{
    [SerializeField]
    float scrollSpeed = 10f;
    [SerializeField]
    int sensivity = 1;
    [SerializeField]
    Transform targetPos;

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (x != 0 || y != 0)
        {
            Vector3 newpos = transform.position + (transform.TransformDirection(new Vector3(x, 0, 0)) + Vector3.up * y) / sensivity;

            transform.position = newpos;
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, 454, 546),
                             Mathf.Clamp(transform.position.y, 135, 155),
                             Mathf.Clamp(transform.position.z, 129, 180));
        }

        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            Vector3 newpos = transform.position + transform.TransformDirection(Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * scrollSpeed);
            transform.position = newpos;
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, 454, 546),
                                  Mathf.Clamp(transform.position.y, 135, 155),
                                  Mathf.Clamp(transform.position.z, 129, 180));
        }

        if (Input.GetMouseButton(1))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, 454, 546),
                      Mathf.Clamp(transform.position.y, 135, 155),
                      Mathf.Clamp(transform.position.z, 129, 180));
            transform.RotateAround(targetPos.position, Vector3.up, Input.GetAxis("Mouse X") * sensivity);
        }
    }
}