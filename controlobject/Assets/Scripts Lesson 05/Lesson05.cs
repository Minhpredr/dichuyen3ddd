using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson05 : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private int force;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            rb.AddTorque(Vector3.up * force, ForceMode.Impulse);
        }

      
    }
}
