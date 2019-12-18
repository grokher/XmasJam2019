using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedSpawn : MonoBehaviour
{
   [SerializeField] private int dollo;
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
        if (enoughSeeds == true && seeds > 0 && Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(seed, new Vector3(transform.position.x, transform.position.y, transform.position.z), new Quaternion(0, 0, 0, 0));
            seeds--;
            dollo += 10;
        }
    }
    private void Shop()
    {
        if (dollo >= 5)
        {
            seeds++;
            dollo -= 5;
        }
        if (dollo >= 250)
        {
            //big bag
        }
        if (dollo >= 100)
        {
            //medium bagg
        }
    }
}
