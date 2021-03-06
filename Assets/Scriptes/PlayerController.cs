﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Assets.Scriptes;

public class PlayerController : MonoBehaviour
{
    public float rotateSpeed = 5f, acceleration = 0.5f;
    private float speed = 0;

    public Text Output;

    void Update()
    {
        if (GameEventManager.currentGameState == GameState.GameRunning)
        {
            Mover();
        }

    }

    void Mover()
    {
        Output.text = "Current Speed : " + (speed * 10).ToString("N2");
        if (Input.GetKey(KeyCode.W))
        {
            speed += (acceleration * Time.deltaTime) / 6;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            speed -= (acceleration * Time.deltaTime * 2) / 6;
        }
        else
        {
            speed /= 1.04f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotateSpeed, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotateSpeed, 0);
        }

        CheckMaxSpeed();                                                //check max speeds
        transform.position += transform.forward * speed;                // directional movement
    }

    public bool Toggle(bool temp)
    {
        if (temp == true)
        {
            return false;
        }
        else return true;
    }

    void CheckMaxSpeed()
    {
        if (speed >= 0.3f)
        {
            speed = 0.3f;
        }
        else if (speed <= -0.25f)
        {
            speed = -0.25f;
        }
    }
}
