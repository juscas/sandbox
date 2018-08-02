using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

    ShipHandler handler;

    Vector3 moveInput;
    Vector3 rotInput;
    bool powered = false;

    void Start ()
    {
        handler = GetComponent<ShipHandler>();
    }

    void Update()
    {
        // Receive the input
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        float u = Input.GetAxisRaw("Up");

        float rh = Input.GetAxisRaw("Mouse X");
        float rv = Input.GetAxisRaw("Mouse Y");
        float ru = Input.GetAxisRaw("Up 2");

        moveInput = new Vector3(h, u, v);
        rotInput = new Vector3(rv, rh, ru);

        if(Input.GetKeyDown(KeyCode.P))
        {
            powered = !powered;
        }
    }

    void FixedUpdate ()
    {
        // Send the input
        handler.MoveInput(moveInput, rotInput, powered);
    }
}
