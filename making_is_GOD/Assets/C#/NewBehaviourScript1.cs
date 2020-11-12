using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    //プレイヤー
    public GameObject player;
    //弾のプレハブ
    public GameObject tama;
    //弾を打ち出す
    private float targetTime = 3.0f;
    private float currentTime = 0;
    //弾を保存しておくリスト
    private List<GameObject> list = new List<GameObject>();

    // Update is called once per frame
    void Update()
    {
        //弾を一秒ごとに打ち出すためのもの
        currentTime += Time.deltaTime;
        if (targetTime < currentTime)
        {
            currentTime = 0;
            //敵の位置を保存
            var pos = this.gameObject.transform.position;
            //弾のプレハブを作成
            var t = Instantiate(tama) as GameObject;
            //リストに弾を保存しておく
            list.Add(t);
            //弾の初期位置を敵の位置にする
            t.transform.position = pos;
        }
        //リストから一つずつ弾を取り出してベクトルの向きを修正する
        foreach (var l in list)
        {
            //弾のvelocityにベクトルを入れる
            //弾からプレイヤーへのベクトルを求めて、正規化し任意の速さ3をかける
            l.GetComponent<Rigidbody2D>().velocity = (player.transform.position - l.transform.position).normalized * 2;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hit");
        }
    }
}
