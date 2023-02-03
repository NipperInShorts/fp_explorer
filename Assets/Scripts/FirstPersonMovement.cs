using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonMovement : MonoBehaviour
{


    // Player movement params
    public Vector3 direction;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void OnPlayerMove(InputValue inputValue) {
        Vector2 inputVector = inputValue.Get<Vector2>();

        direction.x = inputVector.x;
        direction.z = inputVector.y;
    }
}
