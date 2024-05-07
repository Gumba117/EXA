using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class ExperimentalPlayer : MonoBehaviour
{
    public Light2D luz;
    public Jugador jugador;
    SpriteRenderer spriteRenderer;


    //Estas son funciones experimentales que estan hechas para volver el juego mas dificil y divertido
    //Favor de desactivarlas si no se desea evaluarlas

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        jugador = GetComponent<Jugador>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision);
        if (collision.gameObject.GetComponent<Estrella>() != null)
        {
            luz.pointLightOuterRadius -= 0.35f;
            spriteRenderer.color = collision.gameObject.GetComponent<SpriteRenderer>().color;
            jugador.velocidad = jugador.velocidad * 1.1f;
        }
    }
}
