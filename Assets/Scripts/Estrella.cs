using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Estrella : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public float limitesy;
    public float limitesx;
    public float puntaje;

    

    private Color azul = Color.blue;
    private Color rojo = Color.red;
    private Color amarilla = Color.yellow;
    private Color morada = Color.magenta;
    private Color negro = Color.black;

    //Experimental Set
    private Light2D luz;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        luz = GetComponent<Light2D>();
    }
    private void Start()
    {
        ProbColor();
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        Puntaje.puntosingame= Puntaje.puntosingame + puntaje;
        gameObject.SetActive(false);
        GameManager.listo = true;

    }

    public void ProbColor()
    {
       
        int rnd = Random.Range(0, 101);
        if (rnd<=45)
        {
            spriteRenderer.color = azul;
            puntaje = 10;

            luz.intensity = 0; //Experimental
        }
        else if (45<rnd &&  rnd <= 85)
        {
            spriteRenderer.color = rojo;
            puntaje = 20;

            luz.intensity = 0; //Experimental


        }
        else if (85 < rnd && rnd <= 95)
        {
            spriteRenderer.color = amarilla;
            puntaje = 50;

            luz.intensity = 0; //Experimental

        }
        else if (95 < rnd && rnd <= 99)
        {
            spriteRenderer.color = morada;
            puntaje = 100;

            luz.intensity = 0; //Experimental

        }
        else if (99 < rnd && rnd <= 100)//Experimetal feature estrella
        {
            spriteRenderer.color = negro;
            puntaje = 1000;

            luz.intensity = 1; //Experimental

        }
    }
}
