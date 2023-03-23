using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateSpawnLocation : MonoBehaviour
{
    private GameObject spawn;
    [SerializeField]private float spawnOffsetY = 1.5f;

    void Awake()
    {
        spawn = GameObject.FindGameObjectWithTag("SpawnPoint");
    }
    void OnTriggerEnter(Collider other)
    {
        spawn.transform.position = other.transform.position + new Vector3(0, spawnOffsetY ,0);
        print("Updated spawn point");
    }
}
