using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotasion : MonoBehaviour
{
    [SerializeField] Transform zoomOBJParent;

    [SerializeField] Transform canvas = default;

    float speed = 5;
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float dy = -Input.GetAxis("Mouse X") * speed;
            float dx = Input.GetAxis("Mouse Y") * speed;
            // zoomOBJParent.Rotate(dx, dy, 0);
            zoomOBJParent.RotateAround(transform.position, canvas.transform.rotation * Vector3.up, dy);
            zoomOBJParent.RotateAround(transform.position, canvas.transform.rotation * Vector3.right, dx);
        }
    }
}
