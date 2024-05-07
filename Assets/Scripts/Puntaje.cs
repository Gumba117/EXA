using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    private TextMeshProUGUI m_TextMeshProUGUI;
    public static float puntosingame;
    public float puntos;
    public string nombreJugador;

    public TMP_InputField inputname;

    // Start is called before the first frame update
    void Start()
    {
        m_TextMeshProUGUI = GetComponent<TextMeshProUGUI>();
        puntos = 0;
        puntosingame = 0;
    }

    // Update is called once per frame
    void Update()
    {
        m_TextMeshProUGUI.text = ("Puntaje: " + puntos.ToString("0"));
        puntos = puntosingame;

        inputname.characterLimit = 3;

    }



    public void GuardarPuntaje()
    {
        if (SaveMamager.LoadPlayerScore() == null)
        {
            nombreJugador = inputname.text;
            SaveMamager.SavePlayerScore(this);
        }
        else
        {
            if (SaveMamager.LoadPlayerScore().puntajeMaximo < puntos)
            {
                nombreJugador = inputname.text;
                SaveMamager.SavePlayerScore(this);
            }
        }
        
        
    }
    
}
