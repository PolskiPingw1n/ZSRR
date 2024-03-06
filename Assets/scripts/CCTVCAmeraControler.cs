using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CCTVCameraController : MonoBehaviour
{
    //modyfikator prêdkoœci obrotu
    public float turnSpeed = 5f;

    //zakres obrotu kamery w stopniach
    public float turnAngle = 90;

    //czy kamera krêci siê w prawo
    bool turningRight = !true;

    //obiektyw kamery
    Transform cameraLens;

    // Start is called before the first frame update
    void Start()
    {
        Transform cameraPosition = transform.Find("CameraPosition");
        cameraLens = cameraPosition.Find("Cylinder");
    }

    // Update is called once per frame
    void Update()
    {
     
        transform.rotation = Quaternion.Euler(new Vector3(0, Mathf.PingPong(Time.time, 9) * 10 - 45, 0));

        CheckIfPlayerVisible();
    }

    void CheckIfPlayerVisible()
    {
       // Debug.DrawRay(cameraLens.position, cameraLens.TransformDirection(Vector3.down) * 100, Color.yellow);
    }

}