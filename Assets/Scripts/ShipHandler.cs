using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipHandler : MonoBehaviour {

    Vector3 posInput;
    Vector3 rotInput;

    bool powered = true;
    float speed = 150f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void MoveInput(Vector3 move, Vector3 rote, bool power)
    {
        posInput = move;
        rotInput = rote;
        powered = power;

        Move();
    }

    void Move()
    {
        if(powered)
        {
            speed = 150f;
            rb.drag = 10f;
        }
        else
        {
            speed = 0f;
            rb.drag = 0f;
        }

        rb.AddRelativeForce(posInput * speed);
        rb.AddRelativeTorque(rotInput);
    }
}
