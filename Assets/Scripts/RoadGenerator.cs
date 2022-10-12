using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    public GameObject rocket;
    public GameObject[] RoadBack = new GameObject[10];
    public GameObject[] roadPrefabs;
    public float RoadPos;

    void Start()
    {
        SpawnRoad(0);
    }


    void Update()
    {
        if (RoadBack[0].transform.position.x < -20)
        {
            int rnd = Random.Range(0, 3);
            SpawnRoad(rnd);
        }
    }

    private void SpawnRoad(int RoadIndex)
    {
        GameObject nextRoad = Instantiate(roadPrefabs[RoadIndex], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
        RoadBack[0] = nextRoad;

    }
}
