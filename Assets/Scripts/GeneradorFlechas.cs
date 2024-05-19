using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorFlechas : MonoBehaviour
{
    public GameObject flechas;
    public float timeIntervalo = 3;

    void Start()
    {
        InvokeRepeating("GenerarFlecha", 0.0f, timeIntervalo);

    }

    void GenerarFlecha()
    {
        Instantiate(flechas, transform.position, Quaternion.identity);
    }
}
