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
        bool turningRight = true;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (turningRight)
            {
                TurnRight();
            }
            else
            {
                TurnLeft();
            }
            CheckAngle();
        }
        void TurnRight()
        {
            //obróc o 1 stopieñ na sekunde * mno¿nik w prawo
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed);
        }
        void TurnLeft()
        {
            //obróc o 1 stopieñ na sekunde * mno¿nik w lewo
            transform.Rotate(Vector3.down * Time.deltaTime * turnSpeed);
        }
        void CheckAngle()
        {
            //jeœli wychylenie kamery przekroczy po³owê zakresu kamery w prawo to zmieñ kierunek
            if (transform.eulerAngles.y > 45)
            {
                //krêæ siê w lewo
                turningRight = false;
            }
            if (transform.eulerAngles.y < 315)
            {
                //krêæ siê w prawo
                turningRight = true;
            }
            Debug.Log("y: " + transform.eulerAngles.y + "turningRight: " + turningRight);
        }
    }