using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Player;

    public GameObject Computer;

    public Text Score;

    public Sprite[] yorhand = new Sprite[3];

    public Sprite[] randomhand = new Sprite[3];

    void result1() {
        if (GameScenecood.Instance.playerhand < GameScenecood.Instance.cpuhand){
            Score.gameObject.GetComponent<Text>().text = "勝ち勝ち!";
        }
        else
        {
            Score.gameObject.GetComponent<Text>().text = "負け負け！";
        }
    }

    void result2()
    {
        if (GameScenecood.Instance.playerhand > GameScenecood.Instance.cpuhand)
        {
            Score.gameObject.GetComponent<Text>().text = "勝ち勝ち!";
        }
        else
        {
            Score.gameObject.GetComponent<Text>().text = "負け負け！";
        }
    }
    public void Onclick()
    {
        SceneManager.LoadScene("Title");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(GameScenecood.Instance.playerhand);

        Player.gameObject.GetComponent<Image>().sprite = yorhand[GameScenecood.Instance.playerhand];

        Computer.gameObject.GetComponent<Image>().sprite = randomhand[GameScenecood.Instance.cpuhand];
        
        if(GameScenecood.Instance.playerhand == GameScenecood.Instance.cpuhand)        {
            Score.gameObject.GetComponent<Text>().text = "あいこ";
        }
        else if (GameScenecood.Instance.playerhand + GameScenecood.Instance.cpuhand == 2)
        {

        }
        else{
            result1();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
