using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameObject bulletPrefab;

    AudioSource audioSource;
    public AudioClip shotSE;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 nextPosition = transform.position + new Vector3(x, y, 0) * Time.deltaTime * 8f;
        nextPosition = new Vector3(
            Mathf.Clamp(nextPosition.x, -15.0f, 15.0f),
            Mathf.Clamp(nextPosition.y,-1f,20.0f),
            nextPosition.z
            );
        transform.position = nextPosition;
        //transform.position += new Vector3(x, y, 0)*Time.deltaTime*8;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            audioSource.PlayOneShot(shotSE);
        }
    }
}

