using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Flecha : MonoBehaviour
{
    public float velocidad = 5f; 
    public Vector2 direccion = Vector2.left; 
    public string escenaDerrota = "Derrota";

    private void Update()
    {
     
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag == ("Player"))
        {
 
            SceneManager.LoadScene(escenaDerrota);
        }
        if(collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
