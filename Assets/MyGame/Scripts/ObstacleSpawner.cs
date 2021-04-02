using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    private const string spawnConstant = "Spawn";
    public static ObstacleSpawner instance;

    public GameObject[] obstacles;

    public bool gameOver = false;

    public float minSpawnTime, maxSpawnTime;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        StartCoroutine(spawnConstant);
    }
}
