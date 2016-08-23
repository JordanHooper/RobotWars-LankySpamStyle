using UnityEngine;
using System.Collections;

public class Wheel : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey("w"))
        {
            this.transform.Rotate(0, -(Time.deltaTime * 50) - 10, 0);           //	roatate the wheel
        }
        if (Input.GetKey("s"))
        {
            this.transform.Rotate(0, (Time.deltaTime * 25) + 5, 0);             //rotate the wheel
        }
    }
}
