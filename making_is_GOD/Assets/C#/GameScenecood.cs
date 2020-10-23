using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameScenecood : MonoBehaviour
{
    public int playerhand;

    public int cpuhand;

    public readonly static GameScenecood Instance = new GameScenecood();

    public void Onclickgoo(){
        GameScenecood.Instance.playerhand = 0;
        SceneManager.LoadScene("ResultScene");
    }

    public void Onclicktyoki()
    {
        GameScenecood.Instance.playerhand = 1;
        SceneManager.LoadScene("ResultScene");
    }

    public void Onclickpaa()
    {
        GameScenecood.Instance.playerhand = 2;
        SceneManager.LoadScene("ResultScene");
    }

    private void Start()
    {
        GameScenecood.Instance.cpuhand = Random.Range(0, 3);
    }
    private void Update()
    {
        
    }

}
