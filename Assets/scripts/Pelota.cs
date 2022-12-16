using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    [SerializeField]
    Vector3 direction;
    [SerializeField]
    float mSpeed= 1.5f;

    void Start()
    {
        direction = Vector3.right;
        direction.y = Random.Range(-1f, 1f);
            
    }

    void Update()
    {
        transform.position += direction * Time.deltaTime * mSpeed; 
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="Player")
        {


            direction.x = direction.x * -1f;
            direction.y = Random.Range(-1f, 1f);

        }
        if(collision.gameObject.tag =="Pared")
        {

            direction.y = direction.y * -1f;

        }
        Debug.Log("ha chocado" + collision.collider.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("GOL!");
        transform.position = Vector3.zero;
        //escribir código de cambio de direccion de pelota tras marcar

        if (collision.gameObject.tag =="Porteria1")
        {
            Debug.Log("GOL! DEL Jugador2");
            Marcadores.instance.GolJugador2();
        }

        if (collision.gameObject.tag == "Porteria2")
        {
            Debug.Log("GOL! DEL Jugador1");
            Marcadores.instance.GolJugador1();

        }


    }

}



