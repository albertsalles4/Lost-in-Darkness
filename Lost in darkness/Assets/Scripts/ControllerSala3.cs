using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerSala3 : MonoBehaviour {

    public Button boto;
    public Porta porta;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (boto.isOn && !porta.isOpen)
        {
            porta.openDoor();
        }
        else if (!boto.isOn && porta.isOpen)
        {
            porta.closeDoor();
        }
    }
}
