using UnityEngine;
using System.Collections;

public class BombSpawner : MonoBehaviour
{
	// a public object array for which objects to spawn
	public GameObject[] obj;
	//min and max times for another spawn
	public float spawnMin = 3f;
	public float spawnMax = 1f;
	private float xMin = -4f;
	private float xMax = 4f;
	private float yMin = -3f;
	private float yMax = 3f;

	void Start()
	{
		//start spawn 
		Spawn();
	}
	

	void Spawn()
	{
		//get random number
		float rand = Random.Range(0, 1000);
		//if random number is greater than 700 make a bomb
		if (rand > 50)
		{
			float rrx = Random.Range(xMin, xMax);
			float rrxx = Random.Range(xMin, xMax);
			Vector3 ppp = new Vector3(rrxx, 1.5f);
			Vector3 pp = new Vector3(rrx, 1.5f);
			Instantiate(obj[Random.Range(0, obj.GetLength(0))], pp, Quaternion.identity);
			Instantiate(obj[Random.Range(0, obj.GetLength(0))], ppp, Quaternion.identity);
		}
		//invoke spawn at random time interval between min and max
		Invoke("Spawn", Random.Range(spawnMin, spawnMax));
	}

}
