using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBallSpawner : MonoBehaviour {

    public GameObject lastCreatedObject;
    public Transform spawnpoint;
    public Transform objectToSpawn;
    public KeyCode TouchToSpawn = KeyCode.Space;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(TouchToSpawn) || Input.GetMouseButtonDown(0))
        {
            SpawnObject();
        }
    }

    protected virtual void SpawnObject()
    {
        lastCreatedObject = GameObject.Instantiate(objectToSpawn, spawnpoint.position, spawnpoint.rotation).gameObject;
    }
}
