using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float movespeed = 5f;
    public float jumpForce = 5f;

    // Start is called before the first frame update
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
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
    //spróbujmy obejœæ problem z opóŸnieniem wejœcia poprzez przeniesienie go do update
    void Update()
    {
        //sprawdz czy nacisnieto spacjê (skok)
        //zwraca true jeœli zaczêliœmy naciskaæ spacjê w trakcie klatki animacji
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    void Jump()
    {
        //sprawdz czy znajduje siê na poziomie 0
        if (transform.position.y <= Mathf.Epsilon)
        {
            //dodaj si³ê skoku
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }
}
