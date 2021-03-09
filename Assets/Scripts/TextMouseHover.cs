using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMouseHover : MonoBehaviour
{

    Color textColor;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<TextMesh>().color = Color.black;
    }

    private void OnMouseEnter()
    {
        this.gameObject.GetComponent<TextMesh>().color = Color.red;
    }

    private void OnMouseExit()
    {
        this.gameObject.GetComponent<TextMesh>().color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
