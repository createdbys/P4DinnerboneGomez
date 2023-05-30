using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    NavMeshAgent enemyZombie;
    GameObject target;
    Animator anim;

    // Start is called before the first frame update
    private void Start()
    {
        enemyZombie = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    private void Update()
    {
        float dist = Vector3.Distance(transform.position, target.transform.position);
        if(dist < 2)
        {
            StopEnemy();
        }
        else
        {
            GoToTarget();
        }
    }

    private void GoToTarget()
    {
        enemyZombie.isStopped = false;
        anim.SetBool("isRunning", true);
        anim.SetBool("isAttacking", false);
        enemyZombie.SetDestination(target.transform.position);
    }

    private void StopEnemy()
    {
        enemyZombie.isStopped = true;
        anim.SetBool("isRunning", false);
        anim.SetBool("isAttacking", true);
    }
}
