using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnRed : MonoBehaviour
{
    public GameObject firstCube;
    // Start is called before the first frame update
    void Start()
    {
        firstCube.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.HSVToRGB(255f, 1f, 1f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
