using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerSala4 : MonoBehaviour {

    public Porta porta;
    public GameObject calc;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (calc.GetComponent<text>().code.Equals("7") && !porta.isOpen) {
            porta.openDoor();
        } 

	}
}
