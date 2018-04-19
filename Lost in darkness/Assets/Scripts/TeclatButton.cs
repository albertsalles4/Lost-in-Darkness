using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeclatButton : MonoBehaviour {
    public GameObject player;
    public GameObject canvasCalc;
    
    public float distanceMin;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //playerAprop();
    }

    public void playerAprop()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist < distanceMin)// && Input.GetButtonDown("Jump"))
        {
            canvasCalc.SetActive(true);
            player.GetComponent<move>().enabled = false;
        }

    }
}
