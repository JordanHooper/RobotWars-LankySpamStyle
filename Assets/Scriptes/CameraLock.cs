using UnityEngine;
using System.Collections;

public class CameraLock : MonoBehaviour
{
    public Transform target;
    float distance, x, y, z;

    void Update()
    {
        distance = 7;
        x = target.position.x;
        y = target.position.y + distance / 3;
        z = target.position.z - distance;

        this.transform.position = new Vector3(x, y, z);
    }
}
