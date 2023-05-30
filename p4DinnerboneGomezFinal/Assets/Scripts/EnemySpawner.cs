using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyZombie;
    private int xPos;
    private int zPos;
    private int enemyCount;
    private int numEnemies = 10;
    private float spawnRate = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    IEnumerator EnemySpawn()
    {
        while(enemyCount < numEnemies)
        {
            xPos = Random.Range(128, 138);
            zPos = Random.Range(-14, 14);
            Instantiate(enemyZombie, new Vector3(xPos, 2, zPos), Quaternion.identity);
            yield return new WaitForSeconds(spawnRate);
            enemyCount += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
