using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uiscript : MonoBehaviour
{
    public InputField inputField;
    public GameObject textBoxi;
    public GameObject panelRespuesta;
    public GameObject resultado;
    public Text resultadoText; // Variable para el texto del resultado
    public Button volverButton; // Botón para volver a la primera escena

    void Start()
    {
        volverButton.onClick.AddListener(VolverALaPrimeraEscena);
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
            resultadoText.text = "¡Correcto!";
        }
        else
        {
            resultadoText.text = "Incorrecto. Intenta de nuevo.";
        }
        Debug.Log(spawnscript.cantidad);

        resultado.SetActive(true); // Mostrar el panel de resultado
    }

    public void VolverALaPrimeraEscena()
    {
        SceneManager.LoadScene("Caida");
    }
}
