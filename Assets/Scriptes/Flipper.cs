using UnityEngine;
using System.Collections;

public class Flipper : MonoBehaviour
{
    public Transform flipper;
    float timer = 3f;
    bool startClock = false;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            flipper.Rotate(-25, 0, 0);
            flipper.Translate(0, 1, 0);
            startClock = true;
        }
    }

    void Update()
    {
        if (startClock == true)
        {
            timer -= Time.deltaTime;
        }

        if (timer <= 0f)
        {
            flipper.Rotate(25, 0, 0);
            flipper.Translate(0, -1, 0);
            timer = 3f;
            startClock = false;
        }
    }
}
