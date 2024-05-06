using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    private TextMeshProUGUI m_TextMeshProUGUI;
    public static float puntosingame;
    public float puntos;

    // Start is called before the first frame update
    void Start()
    {
        m_TextMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        m_TextMeshProUGUI.text = ("Puntaje: " + puntos.ToString("0"));
        puntos = puntosingame;
    }
}
