using UnityEngine;
using System.Collections;
using Assets.Scriptes;

public class PitFloor : MonoBehaviour
{
    public ParticleSystem temp;

    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Player")
        {
            temp.Play();
           // GameEventManager.currentGameState = GameState.GameEnd;
        }
    }
}
