using UnityEngine;
using System.Collections;
using Assets.Scriptes;

public class PitRelease : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            PitEnumScript.currentPitState = PitState.Lowering;
        }
    }
}
