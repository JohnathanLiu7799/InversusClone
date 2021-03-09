using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparency : MonoBehaviour
{
    [SerializeField] private GameObject currentGameObject;
    [SerializeField] private float alpha;

    // Start is called before the first frame update
    void Start()
    {
        currentGameObject = gameObject;
        ChangeAlpha(currentGameObject.GetComponent<Renderer>().material, alpha);
    }

    void ChangeAlpha(Material mat, float alphaVal)
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaVal);
        mat.SetColor("_Color", newColor);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
