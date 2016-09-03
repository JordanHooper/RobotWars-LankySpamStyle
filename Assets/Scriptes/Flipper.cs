using UnityEngine;
using System.Collections;

public class Flipper : MonoBehaviour
{
    public Transform flipper;
    float timer = 4f;
    bool startClock = false, done = false;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            startClock = true;
        }
    }

    void Flip()
    {
        flipper.Rotate(-35, 0, 0);
        flipper.Translate(0, 1, 0);
        done = true;
    }


    void Update()
    {
        if (startClock == true)
        {
            timer -= Time.deltaTime;
        }

        if (timer <= 3f && done == false)
        {
            Flip();
        }

        if (timer <= 0f)
        {
            flipper.Rotate(35, 0, 0);
            flipper.Translate(0, -0.9f, 0.2f);
            timer = 4f;
            startClock = false;
            done = false;
        }
    }
}
