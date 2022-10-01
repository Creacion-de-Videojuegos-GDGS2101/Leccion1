

//MATERIA: Creación de videojuegos
//GRUPO: GDGS2101
//ALUMNO: José Guillermo Balderas Zamora
// FECHA: 28/09/2022



//importaciones
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
* Clase PlayerController
*
*author: José Guillermo Balderas Zamora
*
* Clase PlayerController que realiza el movimiento 
* del coche dentro del juego (Vertical u Horizontal)
**/
public class PlayerController : MonoBehaviour
{


    // variable tipo float que guarda la velocidad del coche
    public float velocidad = 20;

    //variable tipo float que guarda la velocidad de giro del coche
    public float velGiro = 20;

    //variable tipo float que guarda 
    private float gira;

    private float avanza;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        avanza = Input.GetAxis("Vertical");
        gira = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward*Time.deltaTime*velocidad*avanza);
        transform.Rotate(Vector3.up, Time.deltaTime*velGiro*gira);
    }
}
