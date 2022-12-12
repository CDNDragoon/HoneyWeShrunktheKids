using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class MonsterMovement : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent monster;

    [SerializeField]
    private Transform player;

    [SerializeField]
    private GameObject gameStateController;

    // Update is called once per frame
    private void Update()
    {
        monster.SetDestination(player.position);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Player") return;
        var gameStateScript = gameStateController.GetComponent<GameState>();
        if (gameStateScript != null)
        {
            // I'm killing the player here instantly,
            // we can replace this with damaging player health instead
            gameStateScript.KillPlayer();
        }
    }
}
