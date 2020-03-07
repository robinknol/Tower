using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] int position;
    [SerializeField] bool Ground;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-1, 0, 0);

        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Rotate(90, 0, 0);
        }

        else if(Input.GetKeyDown(KeyCode.S))
        {
            transform.Rotate(-90, 0, 0);
        }

        if (Ground == true)
        {
            GetComponent<Movement>().enabled = false;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        Ground = true;
    }
}
