using UnityEngine;
using System.Collections;

public class PitFloor : MonoBehaviour
{
    public ParticleSystem temp;

    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Player")
        {
            temp.Play();
        }
    }
}
