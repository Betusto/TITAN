using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour {

    public GameObject AnyEnemyBulletGo; // este es nuestro enemu bullet prefab

    // Use this for initialization
    void Start() {

        //lanza una bala despues de un segundo
        Invoke("FireEnemyBullet", 1f);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //metodo para disparar una bala
    void FireEnemyBullet()
    {
        //consigue una referencia a la nave del jugador
        GameObject playerShip = GameObject.Find("PlayerGo");
        GameObject playerShooterShip = GameObject.Find("ShooterPlayerGo");
        GameObject playerShip2 = GameObject.Find("Player2Go");
        GameObject playerShooterShip2 = GameObject.Find("ShooterPlayer2Go");
        GameObject playerShip3 = GameObject.Find("Player3Go");
        GameObject playerShooterShip3 = GameObject.Find("ShooterPlayer3Go");
        GameObject playerShip4 = GameObject.Find("Player4Go");
        GameObject playerShooterShip4 = GameObject.Find("ShooterPlayer4Go");

        //si la nave no esta muerta
        if(playerShip != null || playerShooterShip !=null ||
            playerShip2 != null || playerShooterShip2 != null ||
            playerShip3 != null || playerShooterShip3 != null ||
            playerShip4 != null || playerShooterShip4 != null)
        {
            //instanciar una bala
            GameObject bullet = (GameObject)Instantiate(AnyEnemyBulletGo);

            //marcar la posicion inicial de la bala
            bullet.transform.position = transform.position;
            
            //marcar la direccion final de la bala
            if(playerShip != null)
            {
                Vector2 direction = playerShip.transform.position - bullet.transform.position;
                bullet.GetComponent<EnemyBullet>().SetDirection(direction);

            } else if (playerShooterShip != null)
            {
                Vector2 direction = playerShooterShip.transform.position - bullet.transform.position;
                bullet.GetComponent<EnemyBullet>().SetDirection(direction);

            }
            else if (playerShip2 != null)
            {
                Vector2 direction = playerShip2.transform.position - bullet.transform.position;
                bullet.GetComponent<EnemyBullet>().SetDirection(direction);

            }
            else if (playerShooterShip2 != null)
            {
                Vector2 direction = playerShooterShip2.transform.position - bullet.transform.position;
                bullet.GetComponent<EnemyBullet>().SetDirection(direction);

            }
            else if (playerShip3 != null)
            {
                Vector2 direction = playerShip3.transform.position - bullet.transform.position;
                bullet.GetComponent<EnemyBullet>().SetDirection(direction);

            }
            else if (playerShooterShip3 != null)
            {
                Vector2 direction = playerShooterShip3.transform.position - bullet.transform.position;
                bullet.GetComponent<EnemyBullet>().SetDirection(direction);

            }
            else if (playerShip4 != null)
            {
                Vector2 direction = playerShip4.transform.position - bullet.transform.position;
                bullet.GetComponent<EnemyBullet>().SetDirection(direction);

            }
            else if (playerShooterShip4 != null)
            {
                Vector2 direction = playerShooterShip4.transform.position - bullet.transform.position;
                bullet.GetComponent<EnemyBullet>().SetDirection(direction);

            }
        }
    }
}
