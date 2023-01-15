using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Vector3 newPosition;
    public float speed = 5.0f;
    public int health = 1; //veselyi kod
    public int level = 1; //krutoi

    void Start()
    {
        newPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        health = level + health;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
}
}
