using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camracontroller : MonoBehaviour
{
    Transform player;
    Vector3 cameraOffset;
    // Start is called before the first frame update
    Vector3 cameraSpeed;
    float smoothTime = 0.3f;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        cameraOffset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.position + cameraOFFset; najlepsza
        Vector3 targrtPOsitio = player.position + cameraOffset;
        //transform.position = Vector3.Lerp(transform.position, targrtPOsitio, Time.deltaTime );
        transform.position = Vector3.SmoothDamp(transform.position, targrtPOsitio, ref cameraSpeed, smoothTime);

    }
}
