using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonMovement : MonoBehaviour
{


    // Player movement params
    public Vector3 direction;
    public float speed;

    Rigidbody rbPlayer;

    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.Translate(direction * speed * Time.deltaTime);
        Vector3 localDirection = transform.TransformDirection(direction);
        rbPlayer.MovePosition(rbPlayer.position + (localDirection * speed * Time.deltaTime));
    }

    public void OnPlayerMove(InputValue inputValue) {
        Vector2 inputVector = inputValue.Get<Vector2>();

        direction.x = inputVector.x;
        direction.z = inputVector.y;

        direction.y = 0f;
    }
}
