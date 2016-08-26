using UnityEngine;
using System.Collections;
using Assets.Scriptes;
using UnityEngine.UI;

public class PitEnumScript : MonoBehaviour
{
    public static PitState currentPitState = PitState.Up;

    void Awake()
    {
        currentPitState = PitState.Up;
    }

    void FixedUpdate()
    {
        if (currentPitState == PitState.Lowering)
        {
            PitReleased();
        }
    }

    public void PitReleased()
    {
        //start the pit lowering (animation)
        //set pit to down to y= -3.5
        if (this.transform.position.y >= -3.5f)
        {
            this.transform.Translate(0, -Time.deltaTime, 0);
        }
        else
        {
            this.transform.position = new Vector3(10f, -3.5f, -10f);
        }


    }

    //add trigger + pit down + game stop + particle emitter
}
