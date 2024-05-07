
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float puntajeMaximo;
    public string nombreJugador;

    public PlayerData(Puntaje puntaje)
    {
        if (puntaje.puntos > puntajeMaximo)
        {

            puntajeMaximo = puntaje.puntos;
            nombreJugador = puntaje.nombreJugador;
        }
    }
}
