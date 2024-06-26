using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class correctofalso : MonoBehaviour
{
    public Text txtfruta;
    public string nombrefruta;
    public string[] frutas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Verify()
    {
        txtfruta.text = frutas[Random.Range(0, 5)];
    }
}
