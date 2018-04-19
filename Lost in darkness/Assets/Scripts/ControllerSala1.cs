using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerSala1 : MonoBehaviour {

    public Button boto;
    public Porta porta;
	
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
