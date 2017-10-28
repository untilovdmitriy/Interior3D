using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject menu;

    public void Exit()
    {
        Application.Quit();
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        menu.SetActive(false);
    }

    public void Pause()
    {
        Time.timeScale = 0.0f;
        menu.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Pause();
        }
    }
}
