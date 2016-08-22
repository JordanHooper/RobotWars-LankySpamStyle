using UnityEngine;
using System.Collections;

public class PitRelease : MonoBehaviour
{


    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //release the pit
        }

    }
}
