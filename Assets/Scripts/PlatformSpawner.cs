using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    // a public object array for which objects to spawn
    public GameObject[] obj;
    //
    public float spawnMin = 3f;
    public float spawnMax = 1f;
    private float xMin = 10f;
    private float xMax = 11f;
    private float xxMin = 14f;
    private float xxMax = 15f;
    private float yMin = -3f;
    private float yMax = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //start spawn 
        Spawn();
    }

    // Update is called once per frame
    void Spawn()
    {
        //get random number
        float rand = Random.Range(0, 1000);
        //if random number is greater than 700 make a bomb
        if (rand > 10)
        {
            float rrx = Random.Range(xMin, xMax);
            float rry = Random.Range(yMin, yMax);

            float rrxx = Random.Range(xxMin, xxMax);
            float rryy = Random.Range(yMin, yMax);

            Vector3 pp = new Vector3(rrx, rry);
            Instantiate(obj[Random.Range(0, obj.GetLength(0))], pp, Quaternion.identity);

            Vector3 ppp = new Vector3(rrxx, rryy);
            Instantiate(obj[Random.Range(0, obj.GetLength(0))], ppp, Quaternion.identity);
        }
        //invoke spawn at random time interval between min and max
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));
    }
}
