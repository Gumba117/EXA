using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    
    //Movimiento
    public float velocidad;
    private Vector2 moveInput;
    public Rigidbody2D rigidbody2d;
    public float limitesy;
    public float limitesx;



    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //Movimiento 2.0
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(moveX, moveY).normalized;
        //Limites
        Limites();
    }
    private void FixedUpdate()
    {
        //Movimiento2.0   
        rigidbody2d.MovePosition(rigidbody2d.position + Time.fixedDeltaTime * velocidad * moveInput);
        transform.Rotate(moveInput);
    }
   

    public void Limites()
    {
        Vector3 Posicion = transform.position;
        Posicion.y = Mathf.Clamp(Posicion.y, -limitesy, limitesy);
        Posicion.x = Mathf.Clamp(Posicion.x, -limitesx, limitesx);
        transform.position = Posicion;
    }
}

