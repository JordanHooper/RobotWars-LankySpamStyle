using UnityEngine;
using System.Collections;
using Assets.Scriptes;

public class CameraLock : MonoBehaviour
{
    public Transform target;
    float distance, x, y, z;
    bool follow = false;
    Vector3 location;

    void Awake()
    {
        location = this.transform.position;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            follow = Toggle(follow);
        }

        if (follow == true)
        {
            FollowPlayer();
        }
        else
        {
            this.transform.position = location;
        }
    }

    void FollowPlayer()
    {
        distance = 7;
        x = target.position.x;
        y = target.position.y + distance / 3;
        z = target.position.z - distance;

        this.transform.position = new Vector3(x, y, z);
    }

    public bool Toggle(bool temp)
    {
        if (temp == true)
        {
            return false;
        }
        else return true;
    }
}
