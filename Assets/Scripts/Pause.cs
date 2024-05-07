using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//using static UnityEditor.ShaderData;

public class Pause : MonoBehaviour
{
    public GameObject botonreanu;
    public GameObject botonmenu;

    private void Awake()
    {
        Resume();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            botonmenu.SetActive(true);
            botonreanu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Resume()
    {
        botonmenu.SetActive(false);
        botonreanu.SetActive(false);
        Time.timeScale = 1;
    }

}
