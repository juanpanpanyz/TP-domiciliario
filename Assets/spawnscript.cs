using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnscript : MonoBehaviour
{
    public float minX = 1f;  // Valor mínimo en el eje X
    public float maxX = 15f; // Valor máximo en el eje X
    public float ySpawn = 2f; // Posición fija en el eje Y
    public float Delay = 5.0f;
    public GameObject[] prefabsToSpawn; // Array de prefabs disponibles para spawnear
    public Transform[] spawns; // Array con los spawners
    private GameObject prefabToSpawn; // El prefab que se spawnea actualmente

    public float spawnInterval = 0.5f; // Intervalo entre cada spawn (en segundos)

    void Start()
    {
        // Seleccionar aleatoriamente un prefab inicial
        int randomIndex = Random.Range(0, prefabsToSpawn.Length);
        prefabToSpawn = prefabsToSpawn[randomIndex];

        // Llama a la función para spawnean el prefab inicialmente y repite con el intervalo especificado
        InvokeRepeating("SpawnPrefab", 0f, spawnInterval);

        Invoke("EndDelay", 5.0f);
    }

    void SpawnPrefab()
    {
        // Calcular una posición aleatoria dentro del rango definido
        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPosition = new Vector3(randomX, ySpawn, 0f);

        // Instanciar el prefab seleccionado en la posición calculada
        Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
    }
    void EndDelay()
    {
        SceneManager.LoadScene("Respuesta");
    }
}