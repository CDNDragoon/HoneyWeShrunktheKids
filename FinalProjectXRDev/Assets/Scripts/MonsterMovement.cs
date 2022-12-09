using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterMovement : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent monster;

    [SerializeField]
    private Transform player;

    // Update is called once per frame
    void Update()
    {
        monster.SetDestination(player.position);
    }
}
