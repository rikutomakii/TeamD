using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{

    void Update()
    {
        transform.Translate(0, -0.03f, 0);
        if (transform.position.y < -3.0f)
        {
            transform.position = new Vector3(0, 3.0f, 0);
        }
    }
}
