using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncing : MonoBehaviour
{
    public float BouncingForce = 2f;
    public GameObject thePlayer;

    private void Start()
    {
        thePlayer = gameObject.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            PlayerBall.AddForce(Vector3.up * BouncingForce);
    }
}
