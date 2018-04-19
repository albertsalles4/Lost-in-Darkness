using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour { 

    //private Vector3(0, 2, 0);
    public bool isOpen;

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void openDoor()
    {
        isOpen = true;
        Vector3 novaPosicio = new Vector3(rb.position.x, -rb.position.y, rb.position.z);
        rb.position = novaPosicio;
        Debug.Log(rb.position.ToString());
    }
    public void closeDoor()
    {
        isOpen = false;
        Vector3 novaPosicio = new Vector3(rb.position.x, -rb.position.y, rb.position.z);
        rb.position = novaPosicio;

    }
}
