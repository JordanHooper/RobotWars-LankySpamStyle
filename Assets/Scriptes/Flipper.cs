using UnityEngine;
using System.Collections;

public class Flipper : MonoBehaviour
{
    public Transform flipper;

    void Awake()
    {
        //flipper = GetComponentInParent<Transform>();
    }

    void OnTriggerEnter()
    {
        //Flipper.transform.rotation(-40, 0, -40);
    }

}
