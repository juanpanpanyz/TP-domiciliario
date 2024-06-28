using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uiscript : MonoBehaviour
{
    public InputField inputField;
    public GameObject textBoxi;
    public GameObject panelRespuesta;
    public GameObject resultado;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void Responder()
    {
        string inputText = inputField.text;

        inputField.gameObject.SetActive(false);
        textBoxi.SetActive(false);
        panelRespuesta.SetActive(true);

        if (Convert.ToInt32(inputText) == spawnscript.cantidad)
        {

        }
    }
}