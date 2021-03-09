using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePlayer : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private string color;

    private float horizontalInput;
    private float verticalInput;
    private float fireInput;
    private int fireDelay = 60;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        fireInput = Input.GetAxis("Fire1");
    }

    // FixedUpdate is called once every .02 seconds
    private void FixedUpdate()
    {
        if (fireDelay > 0)
        {
            fireDelay--;
        }

        Vector3 movement = new Vector3(horizontalInput * 5, rb.velocity.y, verticalInput * 5);
        transform.Translate(movement * Time.deltaTime, Space.World);
        
        //Makes Character Face Direction of Movement
        if(movement == Vector3.zero)
        {
            ;
        }
        else
        {
            transform.rotation = Quaternion.LookRotation(movement);
        }

        //rb.velocity = movement;

        if (fireInput != 0 & fireDelay == 0)
        {
            GameObject shot = GameObject.Instantiate(projectile, transform.TransformPoint(Vector3.forward * 1), transform.rotation) as GameObject;
            shot.GetComponent<Rigidbody>().AddForce(transform.forward * 3, ForceMode.VelocityChange);
            fireDelay = 60;

            shot.GetComponent<Bullet>().setCreator(color);
        }

        Vector3 down = transform.TransformDirection(Vector3.down) * 10;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity))
        {
            GameObject obj = hit.collider.gameObject;
            Material mat = obj.GetComponent<MeshRenderer>().material;
            if (mat.color == Color.white)
            {
                Destroy(this.gameObject);
                Application.LoadLevel(3);
            }
        }
    }
}
