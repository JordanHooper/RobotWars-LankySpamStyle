using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum GameState
{
    MenuScreen, PreGame, GameRunning, Paused, GameEnd
}

public class GameEventManager : MonoBehaviour
{
    public GameObject actBut;
    public static GameState currentGameState = GameState.MenuScreen;
    public Text message, timeDisplay;
    bool timer = false;
    float actTime = 5f, gameTimer = 180;

    void Awake()
    {
        message.text = "";
    }

    void Update()
    {
        string mins, seconds;

        CheckStates();

        mins = (gameTimer / 60f).ToString("F0");
        seconds = (gameTimer % 60).ToString("F0");
        timeDisplay.text = mins + " : " + seconds;
        if (gameTimer <= 0f)
        {
            currentGameState = GameState.GameEnd;
        }
    }

    void CheckStates()
    {
        if (currentGameState == GameState.PreGame)
        {
            Destroy(actBut);
            PreGame();
        }
        if (timer == true)
        {
            actTime -= Time.deltaTime;
        }
        if (currentGameState == GameState.GameRunning)
        {
            gameTimer -= Time.deltaTime;
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
