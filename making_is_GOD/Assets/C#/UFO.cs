using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.001f, 0, 0);//敵の速さ

        if (transform.position.y < -6)
        {
            Destroy(gameObject);//敵削除
        }
    }
}
