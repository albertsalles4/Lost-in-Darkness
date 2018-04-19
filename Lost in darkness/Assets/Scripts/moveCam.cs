using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCam : MonoBehaviour {

    Vector3 pos;
    Vector3 v;
	void Start () {
        pos = GameObject.Find("Player").transform.position;
        v = transform.position - pos;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = pos + v;
        pos = GameObject.Find("Player").transform.position;
    }
}
