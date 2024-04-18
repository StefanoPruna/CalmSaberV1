using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] spawnPoints;
    public float beat;
    public float totalTimer;

    private float timer;
    private int beatStage;
    private float StageChangeTime;
    private float nextStageBeatRate;
    private float horizontalOffset;



    // Start is called before the first frame update
    void Start()
    {

        beat = 2.8f;
        beatStage = 1;
        StageChangeTime = 8;


    }

    // Update is called once per frame
    void Update()
    {
        if (totalTimer >= StageChangeTime)
        {

            beat = nextStageBeatRate;
            beatStage = beatStage +1;


        }

        if (timer > beat)
        {

            {

                GameObject cube = Instantiate(cubes[Random.Range(0, 2)], spawnPoints[Random.Range(0, 4)]);
                //cube.transform.localPosition = Vector3.zero + new Vector3(horizontalOffset, 0.5f, 2f);
                cube.transform.localPosition = Vector3.zero + new Vector3(Random.Range(-1, 1f), Random.Range(0f, 1f));
                cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
                timer -= beat;

            }
            
        }
        
        if (beatStage == 1)
        {

            nextStageBeatRate = 2.2f;
            StageChangeTime = 20f;

        }

        if (beatStage == 2)
        {

            nextStageBeatRate = 5f;
            StageChangeTime = 32f;

        }

        if (beatStage == 3)
        {

            nextStageBeatRate = 2.2f;
            StageChangeTime = 52f;

        }

        if (beatStage == 4)
        {

            nextStageBeatRate = 2.2f;
            StageChangeTime = 72f;

        }

        if (beatStage == 5)
        {

            nextStageBeatRate = 5f;
            StageChangeTime = 92f;

        }

        if (beatStage == 6)
        {

            nextStageBeatRate = 2.2f;
            StageChangeTime = 112f;

        }

        timer += Time.deltaTime;

        totalTimer += Time.deltaTime;
    }
}
