using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    
    [SerializeField] GameObject LRightBlock;
    [SerializeField] GameObject LLeftBlock;
    [SerializeField] GameObject LineBlock;
    [SerializeField] GameObject OBlock;
    [SerializeField] GameObject TBlock;
    [SerializeField] GameObject ZRightBlock;
    [SerializeField] GameObject zLeftBlock;
    [SerializeField] bool Ground;

    void Update()
    {
        if(Ground == true)
        {
            BlockRadomizer();
            GetComponent<RandomSpawn>().enabled = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Ground = true;
    }

    void BlockRadomizer()
    {
        int RandomBlock = Random.Range(0, 6);
        if (RandomBlock == 0)
        {
            Instantiate(LRightBlock);
        }
        if (RandomBlock == 1)
        {
            Instantiate(LLeftBlock);
        }
        if (RandomBlock == 2)
        {
            Instantiate(LineBlock);
        }
        if (RandomBlock == 3)
        {
            Instantiate(OBlock);
        }
        if (RandomBlock == 4)
        {
            Instantiate(TBlock);
        }
        if (RandomBlock == 5)
        {
            Instantiate(ZRightBlock);
        }
        if (RandomBlock == 6)
        {
            Instantiate(zLeftBlock);
        }

    }
}
