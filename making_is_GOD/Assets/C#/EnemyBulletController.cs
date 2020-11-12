using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour
{
    private GameObject m_player;
    Vector2 diff;
    public float m_speed;
   // private int timeCount = 0;
    //public GameObject enemyMissilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        //m_speed = 1.0f;
        m_player = GameObject.Find("Player");
        //diff = m_player.transform.position - gameObject.transform.position;
        //diff.Normalize();
        

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hit");

            Destroy(gameObject);
        }
    }
  
    // Update is called once per frame
    void Update()
    {
        Vector2 add = diff;
        
        diff.Set(m_player.transform.position.x - gameObject.transform.position.x, m_player.transform.position.y - gameObject.transform.position.y);
        diff.Normalize();
        gameObject.transform.Translate(add * m_speed);
        //if (diff.magnitude<=2.0f) {
        //    Destroy(gameObject);
        //}
    }
}
