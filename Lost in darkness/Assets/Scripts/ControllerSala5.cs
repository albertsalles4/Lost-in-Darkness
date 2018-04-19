using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerSala5 : MonoBehaviour {

    public GameObject calc;
    private bool end = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (calc.GetComponent<text>().code.Equals("46629") && !end)
        {
            //YOU WIN
            end = true;
            Debug.Log("Oh! UNEXPECTED WIN!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
