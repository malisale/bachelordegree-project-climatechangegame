using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float lookSpeedH = 2f;

    [SerializeField]
    private float lookSpeedV = 2f;

    [SerializeField]
    private float zoomSpeed = 2f;

    [SerializeField]
    private float dragSpeed = 3f;

    private float _yaw = 0f;
    private float _pitch = 0f;

    private bool _checkCameraActive = true;

    private void Start()
    {
        // Initialize the correct initial rotation
        /*this.yaw = this.transform.eulerAngles.y;
        this.pitch = this.transform.eulerAngles.x;*/

        this._yaw = this.transform.eulerAngles.y;
        this._pitch = this.transform.eulerAngles.x;
    }

    private void Update()
    {
        // Only work with the Left Alt pressed
        //if (Input.GetKey(KeyCode.LeftAlt))
       //{
       
            // check if camera is active == true 
            if(_checkCameraActive)
            {
            //Look around with Left Mouse
            if (Input.GetMouseButton(0))
            {
                this._yaw += this.lookSpeedH * Input.GetAxis("Mouse X");
                this._pitch -= this.lookSpeedV * Input.GetAxis("Mouse Y");

                this.transform.eulerAngles = new Vector3(this._pitch, this._yaw, 0f);
            }

            //drag camera around with Middle Mouse
            if (Input.GetMouseButton(2))
            {
                transform.Translate(-Input.GetAxisRaw("Mouse X") * Time.deltaTime * dragSpeed, -Input.GetAxisRaw("Mouse Y") * Time.deltaTime * dragSpeed, 0);
            }

            if (Input.GetMouseButton(1))
            {
                //Zoom in and out with Right Mouse
                this.transform.Translate(0, 0, Input.GetAxisRaw("Mouse X") * this.zoomSpeed * .07f, Space.Self);
            }

            //Zoom in and out with Mouse Wheel
            this.transform.Translate(0, 0, Input.GetAxis("Mouse ScrollWheel") * this.zoomSpeed, Space.Self);
       // }
       }
    }

    public void IsCameraActive(bool isActive)
    {
        _checkCameraActive = isActive;
    }
}
