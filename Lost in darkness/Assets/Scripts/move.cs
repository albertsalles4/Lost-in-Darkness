using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class move : MonoBehaviour {
    public float moveforce = 5;
    void Start() {
    }

    void FixedUpdate()
    {
        Vector3 moveVec = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal"), 0, CrossPlatformInputManager.GetAxis("Vertical")) * moveforce * Time.deltaTime;
        transform.Translate(moveVec);
    }

}
