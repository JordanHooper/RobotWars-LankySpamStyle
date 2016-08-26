using UnityEngine;
using System.Collections;

public class weaponSystem : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            this.transform.Rotate(0, 10, 0);
        }
    }
}
