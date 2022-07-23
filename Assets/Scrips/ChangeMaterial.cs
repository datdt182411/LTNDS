using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material material;
    public GameObject cube;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Cube");
        rend = cube.GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        material = other.gameObject.GetComponent<Renderer>().material;
        rend.sharedMaterial = material;
    }
}
