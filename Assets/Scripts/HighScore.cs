using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    private TextMeshProUGUI m_TextMeshProUGUI;
    public float puntos;
    public string nombreJugador;

    

    // Start is called before the first frame update
    void Start()
    {
        m_TextMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame


    public void ShowHighScore()
    {
        

        if (SaveMamager.LoadPlayerScore() == null)
        {
            
        }
        else
        {
            puntos = SaveMamager.LoadPlayerScore().puntajeMaximo;
            nombreJugador = SaveMamager.LoadPlayerScore().nombreJugador;
            m_TextMeshProUGUI.text = (nombreJugador + " - " + puntos.ToString("0"));
        }
    }

    
}
