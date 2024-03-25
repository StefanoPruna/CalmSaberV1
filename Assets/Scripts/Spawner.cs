using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] spawnPoints;
    public float beat;
    private float horizontalVariation = 10.0f;

    private float timer;
    private int spawnIndex = 0; // Spawn location number

    public global::System.Single HorizontalVariation { get => horizontalVariation; set => horizontalVariation = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>beat)
        {
            float horizontalOffset = Random.Range(-HorizontalVariation, HorizontalVariation) * 10;

            GameObject cube = Instantiate(cubes[Random.Range(0, 2)], spawnPoints[Random.Range(0, 4)]);
            //cube.transform.localPosition = Vector3.zero + new Vector3(horizontalOffset, 0f, 0f);
            cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
            timer -= beat;
        }
        timer += Time.deltaTime;
    }
}
