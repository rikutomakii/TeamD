using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
   // public GameObject player;
    //弾のプレハブ
    public GameObject tama;
    //弾を打ち出す
    //public GameObject m_enemy;
   // private float targetTime = 3.0f;
    //private float currentTime = 0;
    private float interval;
    private float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        interval = 3.0f;
        //m_enemy = GameObject.Find("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > interval)
        {
            //弾をインスタンス化する(生成する)
            GameObject bullet = Instantiate(tama);
            //経過時間を初期化して再度時間計測を始める
           // Vector3 pos = new Vector3(10.0f, 10.0f, 10.0f);
            //生成した弾の座標を決定する(現状X=0,Y=10,Z=20の位置に出力)
            bullet.transform.position = gameObject.transform.position;
            time = 0f;
        }

        //currentTime += Time.deltaTime;
        //if (targetTime < currentTime)
        //{
        //    currentTime = 0;
        //    //敵の位置を保存
        //    var pos = this.gameObject.transform.position;
        //    //弾のプレハブを作成
        //    var t = Instantiate(tama) as GameObject;
        //    //弾の初期位置を敵の位置にする
        //    t.transform.position = pos;
        //}
    }
}
