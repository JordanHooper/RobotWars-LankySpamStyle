using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed = 12f;

    Vector3 movement;
    public Rigidbody botRigidBody;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            botRigidBody.velocity = new Vector3(0f, 0f, 10f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1.5f, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1.5f, 0);
        }
    }
}
