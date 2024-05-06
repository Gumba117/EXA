using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : PoolManager
{
    public Transform[] spawns;
    public int spawnexcluido;
    public int spawnaleat = 0;
    public static bool listo;

    private void Start()
    {
        listo = true;
        ApareceEstrella();
    }
    private void Update()
    {
        if (listo) 
        {
            ApareceEstrella();
            Debug.Log(listo);
        }
    }

    private void ApareceEstrella()
    {
        if (spawnexcluido == spawnaleat)
        {
            spawnaleat = Random.Range(0, spawns.Length);
            spawnexcluido = spawnaleat;
            PedirObjeto();
            listo = false;
        }
        else
        {
            PedirObjeto();
            listo = false;
        }
    }

    public override GameObject PedirObjeto()
    {
        GameObject Objeto = base.PedirObjeto();
        Objeto.transform.position = spawns[spawnaleat].position;
        //Objeto.transform.rotation = jugador.rotation;
        Objeto.SetActive(true);
        //Objeto.GetComponent<Bala>().Disparar(jugador);

        return Objeto;
    }
}
