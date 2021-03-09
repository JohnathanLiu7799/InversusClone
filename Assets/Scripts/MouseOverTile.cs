using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverTile : MonoBehaviour
{

    Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        // Change the Color of the GameObject when the mouse hovers over it
        mat.color = Color.red;
    }
}
