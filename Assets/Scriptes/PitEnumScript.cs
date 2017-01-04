using UnityEngine;
using Assets.Scriptes;

public class PitEnumScript : MonoBehaviour
{
    public static PitState currentPitState = PitState.Up;
    public ParticleSystem temp;

    void Awake()
    {
        currentPitState = PitState.Up;
    }


    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Player")
        {
            temp.Play();
            GameEventManager.currentGameState = GameState.GameEnd;
        }
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

        //this is lowering everything including the trigger = broken
    }

    //add trigger + pit down + game stop + particle emitter
}
