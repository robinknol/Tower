using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Textsomething : MonoBehaviour
{
    [SerializeField] GameObject score;
    [SerializeField] int height;
    [SerializeField] GameObject[] all;
    void Start()
    {
        score.GetComponent<TextMesh>().text = "Score " + height;
    }

    void Update()
    {
        UnityEngine.Ray ray = Camera.main.ScreenPointToRay(new Vector3(0, height, 0));

        Debug.DrawRay(start: ray.origin, dir: ray.direction * 100, Color.green);
    }
}
