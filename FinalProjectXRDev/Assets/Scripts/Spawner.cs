using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject monster;
    //[SerializeField]
    //private Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Instantiate(monster, spawnPoint);
            //gameObject.GetComponent<SphereCollider>().enabled = false;
            monster.SetActive(true);
        }

        Destroy(this, 1);
    }
}
