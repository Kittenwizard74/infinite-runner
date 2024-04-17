using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] obstaculos;
    public Vector2 posicionSpawn;
    public float tiempoDeArranque;
    public float repeticion;

    void Start()
    {
        InvokeRepeating("SpawnObstaculos", tiempoDeArranque, repeticion);
    }

    
    void SpawnObstaculos()
    {
        int random = Random.Range(0, obstaculos.Length);
        GameObject obstauloRandom = obstaculos[random];
        Instantiate(obstauloRandom, posicionSpawn, obstauloRandom.transform.rotation);
    }
}
