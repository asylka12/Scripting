using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    // Start is called before the first frame update
    public float jumpStrength = 2f;
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().jumpStrength =10f;

    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().jump.Strength = 2f;
    }
}
