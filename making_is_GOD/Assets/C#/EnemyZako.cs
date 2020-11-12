using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyZako : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.position -= new Vector3(0,10*Time.deltaTime,0);
    }
}
