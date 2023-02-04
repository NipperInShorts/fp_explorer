using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateBehavior : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player")) {
            gameObject.BroadcastMessage("OpenGate");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.BroadcastMessage("CloseGate");
        }
    }
}
