using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLinealBullet : MonoBehaviour
{
    float speed; //la velocidad de la bala

    // Use this for initialization
    void Start()
    {
        speed = 8f;
    }

    // Update is called once per frame
    void Update()
    {
        //conseguir la poscion actual de la bala
        Vector2 position = transform.position;

        //calcular la nueva posicion de la bala
        position = new Vector2(position.x, position.y - speed * Time.deltaTime);

        //actualiza la poscion de la bala
        transform.position = position;

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)); //Esquina inferior izquierda de la pantalla


        //si la bala sale de la pantalla hay que destruirla
        if (transform.position.y < min.y)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //detecta contacto de la bala del enemigo con el jugador
        if (col.tag == "PlayerShipTag")
        {
            //col.gameObject.GetComponent<PlayerControl>().Hit(1);
            //destruye la bala
            Destroy(gameObject);
        }
    }
}
