using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{ 

    [SerializeField] private int layerMask;
    string creator;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 down = transform.TransformDirection(Vector3.down) * 10;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity))
        {
            GameObject obj = hit.collider.gameObject;
            Material target = obj.GetComponent<MeshRenderer>().material;

            switch (creator)
            {
                case "black":
                    target.color = Color.white;
                    break;

                case "white":
                    target.color = Color.black;
                    break;
            }

            Debug.Log(target.name);
            Debug.Log(creator); 
        }
    }

    public void setCreator(string color)
    {
        creator = color;
    }
}
