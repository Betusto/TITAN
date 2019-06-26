using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    float speed; //la velocidad de la bala
    Vector2 _direction; //la direccion de la bala 
    bool isReady; //para saber cuando la direccion de la bala esta preparada


    //establecer los valores predefinidos de la bala
    void Awake()
    {
        speed = 5f;
        isReady = false;
    }

    //metodo para establecer la direccion de la bala
    public void SetDirection(Vector2 direction)
    {
        //establecer la direccion normal, para conseguir un vector unitario
        _direction = direction.normalized;

        isReady = true;//permite que la bala se mueva
    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (isReady)
        {
            //conseguir la poscion actual de la bala
            Vector2 position = transform.position;

            //calcular la nueva posicion de la bala
            position += _direction * speed * Time.deltaTime;

            //actualiza la poscion de la bala
            transform.position = position;

            //esta es la esquina inferior izquierda de la pantalla
            Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

            //esta es la esquina superior derecha de la pantalla
            Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

            //si la bala sale de la pantalla hay que destruirla
            if ((transform.position.x < min.x) || (transform.position.x > max.x) ||
                (transform.position.y < min.y) || (transform.position.y > max.y))
            {
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //detecta contacto de la bala del jugador con un enemigo
        if (col.tag == "PlayerShipTag")
        {
            //col.gameObject.GetComponent<PlayerControl>().Hit(1);
            //destruye la bala
            Destroy(gameObject);
        }
    }
}
