using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : PoolManager
{
    public Transform[] spawns;
    public int spawnexcluido;
    public int spawnaleat = 0;
    public static bool listo;

    //Tiempo
    public Temporizador temporizador;


    //UI
    public GameObject uiInput;
    public GameObject uiTut;
    public GameObject uiGuardar;
    public GameObject uiMenu;
    



    private void Start()
    {
        
        uiGuardar.SetActive(false);
        uiInput.SetActive(false);
        uiMenu.SetActive(false);
        uiTut.SetActive(true);
        Time.timeScale = 0;

    }
    private void Update()
    {
        if (listo) 
        {
            ApareceEstrella();
           // Debug.Log("Excluido: " + spawnexcluido + " Spawn " + spawnaleat);
        }
       // Debug.Log(temporizador.tiempo);
        if (temporizador.tiempo <= 0f)
        {
           // Debug.Log("Se acabo el tiempo");
            Time.timeScale = 0;
            uiGuardar.SetActive(true);
            uiInput.SetActive(true);
            uiMenu.SetActive(true); 
        }
        
        if (Input.anyKey&& (uiTut.activeInHierarchy==true))
        {
            Time.timeScale = 1;
            listo = true;
            //ApareceEstrella();
            uiTut.SetActive(false);

        }

    }

    private void ApareceEstrella()
    {
        do
        {
            spawnaleat = Random.Range(0, spawns.Length);
        } while (spawnexcluido == spawnaleat);
        if (spawnaleat!=spawnexcluido)
        {
            
            PedirObjeto();
            listo = false;
            spawnexcluido = spawnaleat;
        }
        
       
    }

    public override GameObject PedirObjeto()
    {
        GameObject Objeto = base.PedirObjeto();
        Objeto.transform.position = spawns[spawnaleat].position;
       
        Objeto.SetActive(true);
        Objeto.GetComponent<Estrella>().ProbColor();

        return Objeto;
    }
}
