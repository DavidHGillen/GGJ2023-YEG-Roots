using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSwap : MonoBehaviour
{
    public GameObject[] faces;
    // Start is called before the first frame update
    void Start()
    {
        int ran = Random.Range(0, faces.Length);
        faces[ran].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
