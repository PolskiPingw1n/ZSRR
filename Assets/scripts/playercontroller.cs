using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float movespeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(1, 0, 0) * Time.deltaTime;

        float X = Input.GetAxis("Horizontal");
        Debug.Log(X);

        Vector3 movemen = Vector3.right * X;

        float y = Input.GetAxis("Vertical");

        movemen += Vector3.forward * y;

        movemen = movemen.normalized;

        movemen *= Time.deltaTime;

        movemen *= movespeed;

        transform.position += movemen;
    }
}
