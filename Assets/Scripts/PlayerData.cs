
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float puntajeAcumulado;

    public PlayerData(Puntaje puntaje)
    {
        puntajeAcumulado = puntaje.puntos;
    }
}
