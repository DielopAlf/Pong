using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    [SerializeField]
    KeyCode botonArriba;
    [SerializeField]
    KeyCode botonAbajo;
    [SerializeField]
    float mSpeed = 2f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(botonArriba))
        {

            transform.position += Vector3.up * Time.deltaTime * mSpeed;

        }
        if (Input.GetKey(botonAbajo))
        {

            transform.position += Vector3.down * Time.deltaTime * mSpeed;



        }

    }
}
