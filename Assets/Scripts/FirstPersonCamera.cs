using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonCamera : MonoBehaviour
{
    // Camera attached to player
    public Camera playerCamera;

    // Mouse delta values
    public float deltaX;
    public float deltaY;

    // Players rotation
    public float playerRotX; // x axis in degrees
    public float playerRotY; // y axis in degrees

    // Start is called before the first frame update
    void Start()
    {
        playerCamera = Camera.main;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        playerRotY += deltaX * 0.7f;
        playerRotX -= deltaY * 0.7f;

        // clamp on x axis
        playerRotX = Mathf.Clamp(playerRotX, -90f, 90f);

        // update camera
        playerCamera.transform.localRotation = Quaternion.Euler(playerRotX, 0, 0);
        transform.rotation = Quaternion.Euler(0, playerRotY, 0);
    }

    public void OnCameraLook(InputValue inputValue) {
        Vector2 inputVector = inputValue.Get<Vector2>();
        deltaX = inputVector.x;
        deltaY = inputVector.y;
    }
}
