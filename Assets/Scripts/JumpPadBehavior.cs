using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBadBehavior : MonoBehaviour
{
    public float jumpForce = 10f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            Rigidbody rbPlayer = other.GetComponent<Rigidbody>();

            rbPlayer.AddForce(other.transform.up * jumpForce, ForceMode.Impulse);
        }
    }
}
