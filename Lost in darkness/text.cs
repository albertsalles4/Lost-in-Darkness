using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class text : MonoBehaviour {

    public string code;
    TextMeshProUGUI textMesh;

    void Start()
    {
        code = "";
        textMesh = GameObject.Find("TextCalc").GetComponent<TextMeshProUGUI>();
    }

    public void OnClick0()
    {
        if(textMesh.text.Length < 10)
            textMesh.text += "0";
    }

    public void OnClick1()
    {
        if (textMesh.text.Length < 10)
            textMesh.text += "1";
    }

    public void OnClick2()
    {
        if (textMesh.text.Length < 10)
            textMesh.text += "2";
    }

    public void OnClick3()
    {
        if (textMesh.text.Length < 10)
            textMesh.text += "3";
    }

    public void OnClick4()
    {
        if (textMesh.text.Length < 10)
            textMesh.text += "4";
    }

    public void OnClick5()
    {
        if (textMesh.text.Length < 10)
            textMesh.text += "5";
    }

    public void OnClick6()
    {
        if (textMesh.text.Length < 10)
            textMesh.text += "6";
    }

    public void OnClick7()
    {
        if (textMesh.text.Length < 10)
            textMesh.text += "7";
    }

    public void OnClick8()
    {
        if (textMesh.text.Length < 10)
            textMesh.text += "8";
    }

    public void OnClick9()
    {
        if (textMesh.text.Length < 10)
            textMesh.text += "9";
    }

    public void OnClickEnter()
    {
        code = textMesh.text;
    }

    public void OnClickBorrar()
    {
        textMesh.text = "";
    }
}
