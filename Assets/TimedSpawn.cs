using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour
{
    public GameObject[] spawnee;
    public bool stopSpawning = false;
    public bool selected = false;
    public float spawnTime;
    public float spawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject(){
        var v2 = new Vector2(4,3.4f);
        Instantiate(spawnee[Random.Range(0, 4)], v2, transform.rotation);
        if(stopSpawning){
            CancelInvoke("SpawnObject");
        }
    }

    void Update() {
        if(selected){
            InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
            stopSpawning = false;
            selected = false;
        }
    }
    
}
