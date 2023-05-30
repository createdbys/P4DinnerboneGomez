using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyZombie;
    private int xPos;
    private int zPos;
    private float spawnRate = 2.0f;
    private bool playerIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    IEnumerator EnemySpawn()
    {
        while(playerIsAlive == true)
        {
            xPos = Random.Range(128, 132);
            zPos = Random.Range(-9, 5);
            Instantiate(enemyZombie, new Vector3(xPos, 2, zPos), Quaternion.identity);
            yield return new WaitForSeconds(spawnRate);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
