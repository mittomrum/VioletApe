using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayerToSpawn : MonoBehaviour
{
    [SerializeField] GameObject spawnLocation;
    [SerializeField] GameObject player;

    void Start()
    {
        player.transform.position = spawnLocation.transform.position;
    }
    void OnCollisionEnter(Collision collision)
    {
            print("Collided with OutOfBounds");
        if (collision.gameObject.CompareTag("Player")) {
            player.transform.position = spawnLocation.transform.position;            
        }
    }

}
