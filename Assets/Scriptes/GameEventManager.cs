using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum GameState
{
    MenuScreen, PreGame, GameRunning, Paused, GameEnd
}

public class GameEventManager : MonoBehaviour
{
    public Button actBut;
    public static GameState currentGameState = GameState.MenuScreen;
    public Text message;
    bool timer = false;
    float actTime = 5f;

    void Awake()
    {
        message.text = "";
    }

    void Update()
    {
        if (currentGameState == GameState.PreGame)
        {
            PreGame();
            actBut.enabled = false;
        }
        if (timer == true)
        {
            actTime -= Time.deltaTime;
        }
    }

    void PreGame()
    {
        timer = true;

        if (actTime <= 5f && actTime >= 4f)
        {
            message.text = "3";
        }
        else
        if (actTime <= 4f && actTime >= 3f)
        {
            message.text = "2";
        }
        else
        if (actTime <= 3f && actTime >= 2f)
        {
            message.text = "1";
        }
        else
        if (actTime <= 2f && actTime >= 0f)
        {
            message.text = "ACTIVATE!";
        }
        else
        if (actTime <= 0)
        {
            message.text = "";
            currentGameState = GameState.GameRunning;
        }

    }

    public void StartButton()
    {
        currentGameState = GameState.PreGame;           
    }
}
