using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float sensivity = 3f;
    public float speed = 3f;

    void Update()
    {
        if (Time.timeScale > 0f)
        {
            transform.eulerAngles += new Vector3(-sensivity * Input.GetAxis("Mouse Y"), sensivity * Input.GetAxis("Mouse X"), 0);
            transform.Translate(Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * speed);
            //Camera.main.fieldOfView += Input.GetAxis("Mouse ScrollWheel");

            transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed);
            transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * speed);
        }
    }
}
