using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Textsomething : MonoBehaviour
{
    [SerializeField] Canvas UI;
    [SerializeField] GameObject score;
    [SerializeField] int height;
    void Start()
    {
        score.GetComponent<TextMesh>().text = "Score " + height;
    }

    void Update()
    {
        
    }
}
