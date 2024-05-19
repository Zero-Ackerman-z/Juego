using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D _compRigidbody2D;
    public int directionX;
    public int directionY;
    public int puntuacion = 0;
    private Animator animator;
    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
 
    void Start()
    {
        
    }

 
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            directionX = 1;
            animator.SetFloat("MoveX", directionX);
            animator.SetFloat("MoveY", directionY);
            animator.SetBool("Moving",true);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            directionX = -1;
            animator.SetFloat("MoveX", directionX);
            animator.SetFloat("MoveY", directionY);
            animator.SetBool("Moving",true);
        }
        else
        {
            
            directionX = 0;
            animator.SetBool("Moving", false);
        }

        if (Input.GetKey(KeyCode.W))
        {
            directionY = 1;
            animator.SetFloat("MoveY", directionY);
            animator.SetFloat("MoveX", directionX);
            animator.SetBool("Moving", true);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            directionY = -1;
            animator.SetFloat("MoveY", directionY);
            animator.SetFloat("MoveX", directionX);
            animator.SetBool("Moving", true);
        }
        else
        {
            
            directionY = 0;
            
        } 
        if(puntuacion == 3)
        {
            SceneManager.LoadScene("Victoria");
        }
    }
    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(speed * directionX, speed * directionY);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "NextLevel")
        {
            SceneManager.LoadScene("Nivel2");
        }
    }

}
