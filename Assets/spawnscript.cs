using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnscript : MonoBehaviour
{
    public float ySpawn = 10f; // Posición fija en el eje Y
    public float Delay = 5.0f; // Delay entre prefab y prefab
    public GameObject[] prefabsToSpawn; // Array de prefabs disponibles para spawnear
    private GameObject prefabToSpawn; // El prefab que se spawnea actualmente
    public int minPrefabs = 1; // Cantidad mínima de prefabs que pueden aparecer
    public int maxPrefabs = 10; // Cantidad máxima de prefabs que pueden aparecer
    public float spawnInterval = 0.5f; // Intervalo entre cada spawn (en segundos)
    public static int cantidad;

    void Start()
    {
        // Seleccionar aleatoriamente un prefab inicial
        int randomIndex = Random.Range(0, prefabsToSpawn.Length);
        prefabToSpawn = prefabsToSpawn[randomIndex];

        // Comienza la coroutine para spawnear prefabs
        StartCoroutine(SpawnPrefabs());
    }

    IEnumerator SpawnPrefabs()
    {

            // Seleccionar un número aleatorio de prefabs para spawnear
            cantidad = Random.Range(4, 20);
            int numPrefabsToSpawn = cantidad;

            for (int i = 0; i < numPrefabsToSpawn; i++)
            {
                // Calcular una posición aleatoria dentro del rango definido
                float randomX = Random.Range(10, -15);
                Vector3 spawnPosition = new Vector3(randomX, ySpawn, 0f);

                // Instanciar el prefab seleccionado en la posición calculada
                Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);

                // Esperar el intervalo especificado antes de spawnear el siguiente prefab
                yield return new WaitForSeconds(spawnInterval);
            }

            
            SceneManager.LoadScene("Resultado");
        }
    
}
