using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedSpawn : MonoBehaviour
{
    private int seeds;
    private int plantedTrees;
    private bool enoughSeeds;

    public GameObject seed;

    private void Start()
    {
        seeds = 10;
        enoughSeeds = true;
    }
    private void Update()
    {
        if (enoughSeeds == true && seeds > 0)
        {
            Instantiate(seed, new Vector3(transform.position.x + Random.Range(-1f,1f), transform.position.y, transform.position.z), new Quaternion(0, 0, 0, 0));
            seeds--;
        }

    }
}
