using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static bool GameIsOver;

    public GameObject gameOverUI;

    public GameObject gameUI;

    private UIScript menu;
    
    void Start()
    {
        menu = FindObjectOfType<UIScript>();
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

        menu.ChangeScreenTo(4);

        gameUI.SetActive(false);

    }

}
