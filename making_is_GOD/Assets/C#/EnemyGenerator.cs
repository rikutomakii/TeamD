using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    void Start()
    {
        InvokeRepeating("Spawn", 2f, 0.5f);
    }
    void Spawn()
    {
        Vector3 spawnPosition = new Vector3(
            Random.Range(-15.0f, 15.0f),
            transform.position.y,
            transform.position.z
            );
        Instantiate(
         enemyPrefab,
         spawnPosition,
         transform.rotation
         );
    }

    void Update()
    {
        
    }
}
