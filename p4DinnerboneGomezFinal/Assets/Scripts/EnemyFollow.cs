using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    private NavMeshAgent enemyZombie;
    public Transform Player;

    // Start is called before the first frame update
    void Start()
    {
        enemyZombie = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyZombie.SetDestination(Player.position);
    }
}
