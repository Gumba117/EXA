using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Temporizador : MonoBehaviour
{
    public float tiempo=30;
    private TextMeshProUGUI m_TextMeshProUGUI;

    private void Awake()
    {
        m_TextMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }
    
    private void Update()
    {
        tiempo = tiempo - Time.deltaTime;
        m_TextMeshProUGUI.text =("Tiempo: " + tiempo.ToString("0"));

    }
}
