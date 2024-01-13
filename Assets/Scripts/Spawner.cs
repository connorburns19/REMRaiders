using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawners;
    private int waveNumber = 0;
    private int enemySpawnAmount;
    private int enemiesKilled;
    public GameObject[] enemyTypes; 
    private GameObject currentEnemyType;
    
    private void Start() 
    {
        spawners = new GameObject[5];

        for (int i = 0; i < spawners.Length; i++){
            spawners[i] = transform.GetChild(i).gameObject;
        }
        StartWave();
    }

    private void StartWave(){
        waveNumber++;
        switch(waveNumber){
            case 1:
                currentEnemyType = enemyTypes[0];
                enemySpawnAmount = 10; // Set the number of enemies for the first wave
                break;
            case 2:
                currentEnemyType = enemyTypes[1];
                enemySpawnAmount = 15; // Set the number for the second wave
                break;
            case 3:
                currentEnemyType = enemyTypes[2];
                enemySpawnAmount = 20; // Set the number for the third wave
                break;
            default:
                Debug.Log("All waves complete!");
                return;
        }
        enemiesKilled = 0;
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies(){
        for(int i = 0; i < enemySpawnAmount; i++){
            SpawnEnemy(currentEnemyType);
            yield return new WaitForSeconds(
        2.0f); // Wait for 2 seconds between spawns
        }
    }

    private void SpawnEnemy(GameObject enemyType){
        int spawnerID = Random.Range(0, spawners.Length);
        Instantiate(enemyType, spawners[spawnerID].transform.position, spawners[spawnerID].transform.rotation);
    }

    public void OnEnemyKilled(){
        enemiesKilled++;
        if (enemiesKilled >= enemySpawnAmount){
            NextWave();
        }
    }

    private void NextWave(){
    if(waveNumber < 3){
        StartWave();
    } else {
        Debug.Log("All waves completed!");
    }
}

}
