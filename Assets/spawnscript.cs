using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnscript : MonoBehaviour
{
    public int currentIndex;
    public float minX = 1f;  // Valor mínimo en el eje X
    public float maxX = 15f; // Valor máximo en el eje X
    public float ySpawn = 2f; // Posición fija en el eje Y
    public GameObject[] prefabsToShoot; // Array de prefabs a disparar

    void Start()
    {
            int randomIndex = Random.Range(0, prefabsToShoot.Length);
            GameObject prefabToInstantiate = prefabsToShoot[randomIndex];
            float randomX = Random.Range(minX, maxX);
            Vector3 spawnPosition = new Vector3(randomX, ySpawn, 0f);
            Instantiate(prefabToInstantiate, spawnPosition, Quaternion.identity);
    }

    void Update()
    {

    }
}
