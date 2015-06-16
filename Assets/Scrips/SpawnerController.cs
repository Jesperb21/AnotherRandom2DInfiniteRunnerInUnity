using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnerController : MonoBehaviour {
    public List<GameObject> objects;
    public double minTime;
    public double maxTime;

	// Use this for initialization
	void Start () {
        Spawn();
	}
	
    void Spawn()
    {
        GameObject objectToSpawn = objects[Random.Range(0, objects.Count)];
        Instantiate(objectToSpawn, gameObject.transform.position, Quaternion.identity);
        Invoke("Spawn", (float)(Random.Range((int)(minTime*100), (int)(maxTime*100))/100) );
    }
}
