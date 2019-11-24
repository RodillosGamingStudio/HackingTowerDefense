using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static bool GameIsOver;

    public GameObject gameOverUI;

    public GameObject gameUI;
    
    void Start()
    {
        GameIsOver = false;
    }

    void Update()
    {

        if (GameIsOver)
        {
            return;
        }



        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }

    }

    void EndGame()
    {
        GameIsOver = true;

        gameOverUI.SetActive(true);

        gameUI.SetActive(false);

    }

}
