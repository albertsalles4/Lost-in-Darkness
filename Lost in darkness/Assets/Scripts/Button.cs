using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    public bool isOn = false;
    public GameObject player;
    public float distanceMin;
    public Light llum;

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
            isOn = !isOn;
            canviarLlum();
        } 

    }

    private void canviarLlum()
    {
        if (isOn)
        {
            llum.intensity = 1f;
        } else
        {
            llum.intensity = 0f;
        }
    }
    
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, distanceMin);
    }
}
