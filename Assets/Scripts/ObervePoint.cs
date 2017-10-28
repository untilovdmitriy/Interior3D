using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObervePoint : MonoBehaviour
{
    public Vector3 rotation;

    void OnMouseOver()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Camera.main.transform.position = transform.position;
            Camera.main.transform.rotation = Quaternion.Euler(rotation);
        }
    }
}
