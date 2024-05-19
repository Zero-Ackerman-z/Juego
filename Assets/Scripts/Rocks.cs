using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocks : MonoBehaviour
{
    public GameObject objectToDestroy; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            if (objectToDestroy == null)
            {
                
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("El objeto no puede ser destruido porque el objeto condicional aún no ha sido destruido.");
            }
        }
    }
}
