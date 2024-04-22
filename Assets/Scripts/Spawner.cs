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



    // Start is called before the first frame update
    void Start()
    {

        beat = 2.7f;
        beatStage = 0;
        StageChangeTime = 18f;
        nextStageBeatRate = 2.2f;

    }

    // Update is called once per frame
    void Update()
    {
        if (totalTimer >= StageChangeTime)
        {

            beat = nextStageBeatRate;
            beatStage = beatStage + 1;

            if (beatStage == 1)
            {

                nextStageBeatRate = 2.2f;
                StageChangeTime = 41f;

            }

            if (beatStage == 2)
            {

                nextStageBeatRate = 2f;
                StageChangeTime = 65f;

            }

            if (beatStage == 3)
            {

                nextStageBeatRate = 2.2f;
                StageChangeTime = 89f;

            }

            if (beatStage == 4)
            {

                nextStageBeatRate = 2f;
                StageChangeTime = 113f;

            }

            if (beatStage == 5)
            {

                nextStageBeatRate = 2.7f;
                StageChangeTime = 136f;

            }

            if (beatStage == 6)
            {

                nextStageBeatRate = 2f;
                StageChangeTime = 160f;

            }

            if (beatStage == 7)
            {

                nextStageBeatRate = 2.2f;
                StageChangeTime = 183f;

            }

            if (beatStage == 8)
            {

                nextStageBeatRate = 2f;
                StageChangeTime = 207f;

            }

            if (beatStage == 9)
            {

                nextStageBeatRate = 2f;
                StageChangeTime = 229f;

            }

            if (beatStage == 10)
            {

                nextStageBeatRate = 1.8f;
                StageChangeTime = 255f;

            }

            if (beatStage == 11)
            {

                nextStageBeatRate = 1.8f;
                StageChangeTime = 279f;

            }

            if (beatStage == 12)
            {

                nextStageBeatRate = 2.7f;
                StageChangeTime = 289f;

            }

            if (beatStage == 13)
            {

                nextStageBeatRate = 30f;
                StageChangeTime = 295f;

            }

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


        timer += Time.deltaTime;

        totalTimer += Time.deltaTime;
    }
}
