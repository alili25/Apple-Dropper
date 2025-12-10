using UnityEngine;
using System.Collections;

public class AppleSpawner : MonoBehaviour
{
    public bool gameOver = false;
    public GameObject applePrefab;
    public float spawnDelay = 1f;
    public float dropOffsetY = 1.5f; 


    void Start()
    {
        StartCoroutine(SpawnApple());
    }

    IEnumerator SpawnApple()
    {
        while (!gameOver)
        {
            // Spawn apple
            Vector3 spawnPosition = new Vector3(
                transform.position.x,
                transform.position.y + dropOffsetY,
                0
            );
    
            Instantiate(applePrefab, spawnPosition, Quaternion.identity);
    
            yield return new WaitForSeconds(spawnDelay);
    
            spawnDelay -= 0.05f;   
            spawnDelay = Mathf.Clamp(spawnDelay, 0.2f, 3f); 
        }
    }

}
