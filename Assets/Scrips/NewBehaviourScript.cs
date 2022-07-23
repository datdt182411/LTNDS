using System.Collections;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Material[] material;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    void OncollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Box")
        {
            rend.sharedMaterial = material[1];

        }
        else
        {
            rend.sharedMaterial = material[2];
        }

    }
}
