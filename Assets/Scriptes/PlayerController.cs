using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float rotateSpeed = 1.8f, acceleration = 0.5f;
    private float speed = 0;

    public Text Output;

    void Update()
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

        //speed -= (speed / 4);                                         // try and decrease over time
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
