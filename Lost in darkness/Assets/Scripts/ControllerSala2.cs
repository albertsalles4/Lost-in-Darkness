using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerSala2 : MonoBehaviour {

    public Button boto1;
    public Button boto2;
    public Button boto3;

    public Porta porta;

    public bool condicio1;
    public bool condicio2;
    public bool condicio3;

    // Update is called once per frame
    void Update () {

        if ((condicio1 && !boto1.isOn) || (condicio2 && !boto2.isOn) || (porta.isOpen && !boto3.isOn))
        {
            condicio1 = false;
            condicio2 = false;
            if (porta.isOpen)
            {
                porta.closeDoor();
            }
        }

        if (condicio2 && boto1.isOn && boto2.isOn && boto3.isOn && !porta.isOpen)
        {
            porta.openDoor();
        }

        if (condicio1 && boto1.isOn && boto2.isOn && !boto3.isOn)
        {
            condicio2 = true;
        }

        if (boto1.isOn && !boto2.isOn && !boto3.isOn)
        {
            condicio1 = true;
        }

        

    }
}
