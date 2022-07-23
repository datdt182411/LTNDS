using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONOFF : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonClicked()
    {
        if (obj.activeInHierarchy == true)
            obj.SetActive(false);
        else 
            obj.SetActive(true);
    }
}
