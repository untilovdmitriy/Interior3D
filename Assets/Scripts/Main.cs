using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject pointLight;

    void Start()
    {
        pointLight.SetActive(true);
    }
}
