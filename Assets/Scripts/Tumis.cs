using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tumis : MonoBehaviour
{
    public Player jugador;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject == jugador.gameObject)
        {
            jugador.puntuacion++;

            
            Destroy(gameObject);
        }
    }
}
