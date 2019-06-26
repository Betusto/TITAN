using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour //Script para la generacion del Enemigo
{
    public GameObject EnemyGo; //este es nuestro prefab enemy
    public GameObject Enemy2Go; //este es nuestro prefab enemy2
    public GameObject Enemy3Go; //este es nuestro prefab enemy3
    public GameObject Enemy4Go; //este es nuestro prefab enemy4
    public GameObject Enemy5Go; //este es nuestro prefab enemy5
    public GameObject Enemy6Go; //este es nuestro prefab enemy6

    float maxSpawnRateInSecondsEnemyGo  = 5f;
    float maxSpawnRateInSecondsEnemy2Go = 5f;
    float maxSpawnRateInSecondsEnemy3Go = 5f;
    float maxSpawnRateInSecondsEnemy4Go = 5f;
    float maxSpawnRateInSecondsEnemy5Go = 5f;
    float maxSpawnRateInSecondsEnemy6Go = 5f;


    void SpawnEnemy()
    {
        //Inicializacion del enemigo1
        if (LevelSelectorControl.select2 == 0 || LevelSelectorControl.select2 == 1 || LevelSelectorControl.select2 == 2 ||
           LevelSelectorControl.select2 == 3 || LevelSelectorControl.select2 == 4)
        {
            Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)); //Esquina inferior izquierda de la pantalla
            Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1)); //Esquina superior derecha de la pantalla

            //instalar un enemigo
            GameObject anEnemy = (GameObject)Instantiate(EnemyGo);
            anEnemy.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);

            //registro de la generacion del siguiente enemigo
            ScheduleNextEnemySpawn();
        }

        //Inicializacion del enemigo2
        if (LevelSelectorControl.select2 == 0)
        {
            //registro de la generacion del siguiente enemigo
            ScheduleNextEnemy2Spawn();
        }

        //Inicializacion del enemigo 3
        if (LevelSelectorControl.select2 == 1)
        {
            //registro de la generacion del siguiente enemigo
            ScheduleNextEnemy3Spawn();
        }

        //Inicializacion del enemigo 4
        if (LevelSelectorControl.select2 == 2)
        {
            //registro de la generacion del siguiente enemigo
            ScheduleNextEnemy4Spawn();
        }

        //Inicializacion del enemigo 5
        if (LevelSelectorControl.select2 == 3)
        {
            //registro de la generacion del siguiente enemigo
            ScheduleNextEnemy5Spawn();
        }

        //Inicializacion del enemigo 6
        if (LevelSelectorControl.select2 == 4)
        {
            //registro de la generacion del siguiente enemigo
            ScheduleNextEnemy6Spawn();
        }




    }


    //metodo del enemigo generico
    void ScheduleNextEnemySpawn()
    {
        float spawnInNSeconds;

        if (maxSpawnRateInSecondsEnemyGo > 1f)
        {
            //escoge un numero entre 1 y la variable maxSpawnRateInSeconds
            spawnInNSeconds = Random.Range(1f, maxSpawnRateInSecondsEnemyGo);
        }
        else
            spawnInNSeconds = 1f;

        Invoke("SpawnEnemy", spawnInNSeconds);

    }


    //metodo del enemigo 2
    void ScheduleNextEnemy2Spawn()
    {
        float spawnInNSeconds;
            spawnInNSeconds = Random.Range(1f, 100f);

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)); //Esquina inferior izquierda de la pantalla
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1)); //Esquina superior derecha de la pantalla

        if (spawnInNSeconds <= 98f)
        {
            CancelInvoke("ScheduleNextEnemy2Spawn");
        }
        else
        {
            //instalar un enemigo
            GameObject anEnemy = (GameObject)Instantiate(Enemy2Go);
            anEnemy.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
            Invoke("ScheduleNextEnemy2Spawn", spawnInNSeconds);
        }


        
    }

    //metodo del enemigo 3
    void ScheduleNextEnemy3Spawn()
    {
        float spawnInNSeconds;
        spawnInNSeconds = Random.Range(1f, 100f);

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)); //Esquina inferior izquierda de la pantalla
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1)); //Esquina superior derecha de la pantalla

        if (spawnInNSeconds <= 84f)
        {
            CancelInvoke("ScheduleNextEnemy3Spawn");
        }
        else
        {
            //instalar un enemigo
            GameObject anEnemy = (GameObject)Instantiate(Enemy3Go);
            anEnemy.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
            Invoke("ScheduleNextEnemy3Spawn", spawnInNSeconds);
        }
    }

    //metodo del enemigo 4
    void ScheduleNextEnemy4Spawn()
    {
        float spawnInNSeconds;
        spawnInNSeconds = Random.Range(1f, 100f);

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)); //Esquina inferior izquierda de la pantalla
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1)); //Esquina superior derecha de la pantalla

        if (spawnInNSeconds <= 86f)
        {
            CancelInvoke("ScheduleNextEnemy4Spawn");
        }
        else
        {
            //instalar un enemigo
            GameObject anEnemy = (GameObject)Instantiate(Enemy4Go);
            anEnemy.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
            Invoke("ScheduleNextEnemy4Spawn", spawnInNSeconds);
        }
    }

    //metodo del enemigo 5
    void ScheduleNextEnemy5Spawn()
    {
    float spawnInNSeconds;
    spawnInNSeconds = Random.Range(1f, 100f);

    Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)); //Esquina inferior izquierda de la pantalla
    Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1)); //Esquina superior derecha de la pantalla

    if (spawnInNSeconds <= 88f)
    {
        CancelInvoke("ScheduleNextEnemy5Spawn");
    }
    else
    {
        //instalar un enemigo
        GameObject anEnemy = (GameObject)Instantiate(Enemy5Go);
        anEnemy.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
        Invoke("ScheduleNextEnemy5Spawn", spawnInNSeconds);
    }
}

    //metodo del enemigo 6
    void ScheduleNextEnemy6Spawn()
    {
        float spawnInNSeconds;
        spawnInNSeconds = Random.Range(1f, 100f);

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)); //Esquina inferior izquierda de la pantalla
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1)); //Esquina superior derecha de la pantalla

        if (spawnInNSeconds <= 90f)
        {
            CancelInvoke("ScheduleNextEnemy6Spawn");
        }
        else
        {
            //instalar un enemigo
            GameObject anEnemy = (GameObject)Instantiate(Enemy6Go);
            anEnemy.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
            Invoke("ScheduleNextEnemy6Spawn", spawnInNSeconds);
        }
    }

    //metodo para aumentar la dificultad del juego (aumentar la cant. de enemigos)
    void IncreaseSpawnRate()
    {
        //si se encuentra en el primer nivel (marte)
        if (LevelSelectorControl.select2 == 0)
        {
            //aumenta la probabiliad del enemigo generico
            if (maxSpawnRateInSecondsEnemyGo > 1f)

                maxSpawnRateInSecondsEnemyGo--;

            if (maxSpawnRateInSecondsEnemyGo == 1f)
                CancelInvoke("IncreaseSpawnRate");

            //aumenta la probabiliad del enemigo 2
            if (maxSpawnRateInSecondsEnemy2Go > 1f)

                maxSpawnRateInSecondsEnemy2Go--;

            if (maxSpawnRateInSecondsEnemy2Go == 1f)
                CancelInvoke("IncreaseSpawnRate");
        }

        //si se encuentra en el segundo nivel (europa)
        if (LevelSelectorControl.select2 == 1)
        {
            //aumenta la probabiliad del enemigo generico
            if (maxSpawnRateInSecondsEnemyGo > 1f)

                maxSpawnRateInSecondsEnemyGo--;

            if (maxSpawnRateInSecondsEnemyGo == 1f)
                CancelInvoke("IncreaseSpawnRate");

            //aumenta la probabiliad del enemigo 3
            if (maxSpawnRateInSecondsEnemy3Go > 1f)

                maxSpawnRateInSecondsEnemy3Go--;

            if (maxSpawnRateInSecondsEnemy3Go == 1f)
                CancelInvoke("IncreaseSpawnRate");
        }

        //si se encuentra en el tercer nivel (saturno)
        if (LevelSelectorControl.select2 == 2)
        {
            //aumenta la probabiliad del enemigo generico
            if (maxSpawnRateInSecondsEnemyGo > 1f)

                maxSpawnRateInSecondsEnemyGo--;

            if (maxSpawnRateInSecondsEnemyGo == 1f)
                CancelInvoke("IncreaseSpawnRate");

            //aumenta la probabiliad del enemigo 4
            if (maxSpawnRateInSecondsEnemy4Go > 1f)

                maxSpawnRateInSecondsEnemy4Go--;

            if (maxSpawnRateInSecondsEnemy4Go == 1f)
                CancelInvoke("IncreaseSpawnRate");
        }

        //si se encuentra en el cuarto nivel (encelado)
        if (LevelSelectorControl.select2 == 3)
        {
            //aumenta la probabiliad del enemigo generico
            if (maxSpawnRateInSecondsEnemyGo > 1f)

                maxSpawnRateInSecondsEnemyGo--;

            if (maxSpawnRateInSecondsEnemyGo == 1f)
                CancelInvoke("IncreaseSpawnRate");

            //aumenta la probabiliad del enemigo 3
            if (maxSpawnRateInSecondsEnemy5Go > 1f)

                maxSpawnRateInSecondsEnemy5Go--;

            if (maxSpawnRateInSecondsEnemy5Go == 1f)
                CancelInvoke("IncreaseSpawnRate");
        }

        //si se encuentra en el sexto nivel (titan)
        if (LevelSelectorControl.select2 == 4)
        {
            //aumenta la probabiliad del enemigo generico
            if (maxSpawnRateInSecondsEnemyGo > 1f)

                maxSpawnRateInSecondsEnemyGo--;

            if (maxSpawnRateInSecondsEnemyGo == 1f)
                CancelInvoke("IncreaseSpawnRate");

            //aumenta la probabiliad del enemigo 3
            if (maxSpawnRateInSecondsEnemy6Go > 1f)

                maxSpawnRateInSecondsEnemy6Go--;

            if (maxSpawnRateInSecondsEnemy6Go == 1f)
                CancelInvoke("IncreaseSpawnRate");
        }
    }

    //metodo para iniciar la generacion de enemigos
    public void ScheduleEnemySpawner()
    {
        //reiniciar el ratio de generacion de enemigos
        maxSpawnRateInSecondsEnemyGo = 5f;
        maxSpawnRateInSecondsEnemy2Go = 5f;
        maxSpawnRateInSecondsEnemy3Go = 5f;
        maxSpawnRateInSecondsEnemy4Go = 5f;
        maxSpawnRateInSecondsEnemy5Go = 5f;
        maxSpawnRateInSecondsEnemy6Go = 5f;

        //Inicializacion del enemigo2
        if (LevelSelectorControl.select2 == 0)
        {
            Invoke("SpawnEnemy", maxSpawnRateInSecondsEnemyGo);

            //aumentar la probabilidad de generacion cada 30 segundos
            InvokeRepeating("IncreaseSpawnRate", 0f, 30f);
        }

        //Inicializacion del enemigo 3
        if (LevelSelectorControl.select2 == 1)
        {
            Invoke("SpawnEnemy", maxSpawnRateInSecondsEnemyGo);

            //aumentar la probabilidad de generacion cada 30 segundos
            InvokeRepeating("IncreaseSpawnRate", 0f, 30f);
        }

        //Inicializacion del enemigo 4
        if (LevelSelectorControl.select2 == 2)
        {
            Invoke("SpawnEnemy", maxSpawnRateInSecondsEnemyGo);

            //aumentar la probabilidad de generacion cada 30 segundos
            InvokeRepeating("IncreaseSpawnRate", 0f, 30f);
        }

        //Inicializacion del enemigo 5
        if (LevelSelectorControl.select2 == 3)
        {
            Invoke("SpawnEnemy", maxSpawnRateInSecondsEnemyGo);

            //aumentar la probabilidad de generacion cada 30 segundos
            InvokeRepeating("IncreaseSpawnRate", 0f, 30f);
        }

        //Inicializacion del enemigo 6
        if (LevelSelectorControl.select2 == 4)
        {
            Invoke("SpawnEnemy", maxSpawnRateInSecondsEnemyGo);

            //aumentar la probabilidad de generacion cada 30 segundos
            InvokeRepeating("IncreaseSpawnRate", 0f, 30f);
        }
    }

    //metodo para detener la generacion de enemigos
    public void UnscheduleEnemySpawner()
    {
        CancelInvoke("SpawnEnemy");
        CancelInvoke("IncreaseSpawnRate");
    }
}
























/*
    float maxSpawnRateInSeconds = 5f;

	// Use this for initialization
	/*void Start () {
        Invoke("SpawnEnemy", maxSpawnRateInSeconds);

        //aumentar la probabilidad de generacion cada 30 segundos
        InvokeRepeating("IncreaseSpawnRate", 0f, 30f);
	}*/ //abajo (ScheduleEnemySpawner) se vuelve aescribir esta funcion por el game manager
	/*
	// Update is called once per frame
	void Update () {
		
	}
    //metodo para generar un enemigo
    void SpawnEnemy()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)); //Esquina inferior izquierda de la pantalla
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1)); //Esquina superior derecha de la pantalla

        //instalar un enemigo
        GameObject anEnemy = (GameObject)Instantiate(EnemyGo);
        anEnemy.transform.position = new Vector2(Random.Range (min.x, max.x), max.y);

        //registro de la generacion del siguiente enemigo
        ScheduleNextEnemySpawn();
    }


    //metodo para generar el siguiente enemigo
    void ScheduleNextEnemySpawn()
    {
        float spawnInNSeconds;

        if (maxSpawnRateInSeconds > 1f)
        {
            //escoge un numero entre 1 y la variable maxSpawnRateInSeconds
            spawnInNSeconds = Random.Range(1f, maxSpawnRateInSeconds);
        }
        else
            spawnInNSeconds = 1f;

        Invoke ("SpawnEnemy", spawnInNSeconds);
    }
    
    //metodo para aumentar la dificultad del juego (aumentar la cant. de enemigos)
    void IncreaseSpawnRate()
    {
        if (maxSpawnRateInSeconds > 1f)
            maxSpawnRateInSeconds--;

        if (maxSpawnRateInSeconds == 1f)
            CancelInvoke("IncreaseSpawnRate");
    }

    //metodo para iniciar la generacion de enemigos
    public void ScheduleEnemySpawner()
    {
        //reiniciar el ratio de generacion de enemigos
        maxSpawnRateInSeconds = 5f;

        Invoke("SpawnEnemy", maxSpawnRateInSeconds);

        //aumentar la probabilidad de generacion cada 30 segundos
        InvokeRepeating("IncreaseSpawnRate", 0f, 30f);
    }

    //metodo para detener la generacion de enemigos
    public void UnscheduleEnemySpawner()
    {
        CancelInvoke("SpawnEnemy");
        CancelInvoke("IncreaseSpawnRate");
    }
}
*/