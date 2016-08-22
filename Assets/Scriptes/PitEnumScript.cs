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
        //set pit to down

    }

    //add trigger + pit down + game stop + particle emitter
}
