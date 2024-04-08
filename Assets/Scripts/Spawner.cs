using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] spawnPoints;
    public float beat;

    private float timer;
    private float totalTimer;
    private int beatStage;
    private float StageChangeTime;
    private float nextStageBeatRate;


    // Start is called before the first frame update
    void Start()
    {

        beat = 1f;
        beatStage = 0;
        StageChangeTime = 30f;


    }

    // Update is called once per frame
    void Update()
    {
        if (totalTimer => StageChangeTime)
        {

            beat = nextStageBeatRate;
            beatStage = +1f;

        }

        if (timer > beat)
        {

            GameObject cube = Instantiate(cubes[Random.Range(0, 2)], spawnPoints[Random.Range(0, 4)]);
            //cube.transform.localPosition = Vector3.zero + new Vector3(horizontalOffset, 0f, 0f);
            cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
            timer -= beat;
        }
        
        if (beatStage = 1)
        {

            nextStageBeatRate = 0.5f;
            StageChangeTime = 30.0f;

        }

        timer += Time.deltaTime;

        totalTimer += Time.deltaTime;
    }
}
