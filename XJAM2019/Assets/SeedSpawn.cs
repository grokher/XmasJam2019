using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class SeedSpawn : MonoBehaviour
{
   [SerializeField] private int dollo;
    private int seeds;
    private int plantedTrees;
    private bool enoughSeeds;
    private int Planted = 0;
    public Text SeedText;

    public GameObject seed;

    private void Start()
    {
        seeds = 10;
        enoughSeeds = true;
    }
    private void Update()
    {
        Debug.Log(Planted);
        if (enoughSeeds == true && seeds > 0 && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(seed, new Vector3(transform.position.x, transform.position.y, transform.position.z), new Quaternion(0, 0, 0, 0));
            seeds--;
            Planted++;
            dollo += 10;
        }
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
        if (Planted >= 420)
        {
            End();
        }
        SeedText.text = "Seeds Planted: " + Planted.ToString();
    }
    private void End()
    {
        SceneManager.LoadScene("End");
    }
}
